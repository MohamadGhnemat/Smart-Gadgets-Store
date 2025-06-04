using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using smartGadgetsStore.Models;
using smartGadgetsStore.Models.Repositorie;
using smartGadgetsStore.ViewModels;

namespace smartGadgetsStore.Controllers
{
    public class OrderDetailController : Controller
    {
        IRepositorie<OrderDetail> OrderDetailRepo;
        IRepositorie<Order> OrderRepo;
        IRepositorie<Product> ProductRepo;
        public OrderDetailController(IRepositorie<OrderDetail> repositorie, IRepositorie<Order> repositorie1, IRepositorie<Product> repositorie2)
        {
         OrderDetailRepo = repositorie;   
            OrderRepo = repositorie1;
            ProductRepo = repositorie2;
        }
        // GET: OrderDetailController
        public ActionResult Index()
        {
            var data = OrderDetailRepo.View().ToList();
            return View(data);
        }

        // GET: OrderDetailController/Details/5
        public ActionResult Details(int id)
        {
            var data = OrderDetailRepo.Find(id);
            return View(data);
        }

        // GET: OrderDetailController/Create
        public ActionResult Create()
        {
            var obj = new VwOrderDetailProductOrder
            {
                lstOrders = OrderRepo.View().ToList(),
                lstProducts = ProductRepo.View().ToList(),
            };
            return View(obj);
        }

        // POST: OrderDetailController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderDetail collection)
        {
            try
            {
                OrderDetailRepo.Add(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderDetailController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = OrderDetailRepo.Find(id);
            var obj = new VwOrderDetailProductOrder
            {
                OrderDetailID = data.OrderDetailID,
                OrderID = data.OrderID,
                ProductID = data.ProductID,
                Quantity = data.Quantity,
                UnitPrice = data.UnitPrice,
                lstOrders = OrderRepo.View().ToList(),
                lstProducts = ProductRepo.View().ToList(),
            };
            return View(obj);
         
        }

        // POST: OrderDetailController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, OrderDetail collection)
        {
            try
            {
                OrderDetailRepo.Update(id , collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderDetailController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = OrderDetailRepo.Find(id);
            return View(data);
        }

        // POST: OrderDetailController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, OrderDetail collection)
        {
            try
            {
                OrderDetailRepo.Delete(id , collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
