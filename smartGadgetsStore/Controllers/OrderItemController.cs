using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using smartGadgetsStore.Models;
using smartGadgetsStore.Models.Repositorie;
using smartGadgetsStore.ViewModels;

namespace smartGadgetsStore.Controllers
{
    public class OrderItemController : Controller
    {
        IRepositorie<OrderItem> OrderItemRepo;
        IRepositorie<Order> OrderRepo;
        IRepositorie<Product> ProductRepo;
        public OrderItemController(IRepositorie<OrderItem> repositorie, IRepositorie<Order> repositorie1, IRepositorie<Product> repositorie2)
        {
            OrderItemRepo = repositorie;
            OrderRepo = repositorie1;
            ProductRepo = repositorie2;
        }
        // GET: OrderItemController
        public ActionResult Index()
        {
            var data = OrderItemRepo.View().ToList();
            return View(data);
        }

        // GET: OrderItemController/Details/5
        public ActionResult Details(int id)
        {
            var data = OrderItemRepo.Find(id);
            return View(data);
        }

        // GET: OrderItemController/Create
        public ActionResult Create()
        {
            var obj = new VwOrderItemProductOrder { 
              lstOrders  = OrderRepo.View().ToList(),
               lstProducts = ProductRepo.View().ToList(),
            };
            return View(obj);
        }

        // POST: OrderItemController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderItem collection)
        {
            try
            {
                OrderItemRepo.Add(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderItemController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = OrderItemRepo.Find(id);
            var obj = new VwOrderItemProductOrder
            {
                OrderItemID = data.OrderItemID,
                OrderID =data.OrderID,
                ProductID =data.ProductID,
                Quantity =data.Quantity,
                UnitPrice =data.UnitPrice,
                lstOrders = OrderRepo.View().ToList(),
                lstProducts = ProductRepo.View().ToList(),
            };
            return View(obj);
        }

        // POST: OrderItemController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, OrderItem collection)
        {
            try
            {
                OrderItemRepo.Update(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderItemController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = OrderItemRepo.Find(id);
            return View(data);
        }

        // POST: OrderItemController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,OrderItem collection)
        {
            try
            {
                OrderItemRepo.Delete(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
