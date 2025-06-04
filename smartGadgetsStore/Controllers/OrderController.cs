using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using smartGadgetsStore.Models;
using smartGadgetsStore.Models.Repositorie;
using smartGadgetsStore.ViewModels;

namespace smartGadgetsStore.Controllers
{
    public class OrderController : Controller
    {
        IRepositorie<Order> OrderRepo;
        IRepositorie<User> UserRepo;

        public OrderController(IRepositorie<Order> repositorie , IRepositorie<User> repositorie1)
        {
            OrderRepo = repositorie;
            UserRepo = repositorie1;
        }
        // GET: OrderController
        public ActionResult Index()
        {
            var data = OrderRepo.View().ToList();
            return View(data);
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            var data  = OrderRepo.Find(id);
            return View(data);
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {
            var obj = new VwOrderUser
            {
                lstUsers = UserRepo.View().ToList(),
                };
            return View(obj);
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Order collection)
        {
            try
            {
                OrderRepo.Add(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = OrderRepo.Find(id);
            var obj = new VwOrderUser
            {
                OrderID =data.OrderID,
                UserID= data.UserID,
                Status = data.Status,
                TotalAmount = data.TotalAmount,
                OrderDate = data.OrderDate,
                lstUsers = UserRepo.View().ToList(),
            };
            return View(obj);
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Order collection)
        {
            try
            {
                OrderRepo.Update(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = OrderRepo.Find(id);
            return View(data);
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Order collection)
        {
            try
            {
                OrderRepo.Delete(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
