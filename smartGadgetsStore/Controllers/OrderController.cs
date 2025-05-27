using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using smartGadgetsStore.Models;
using smartGadgetsStore.Models.Repositorie;

namespace smartGadgetsStore.Controllers
{
    public class OrderController : Controller
    {
        IRepositorie<Order> OrderRepo;
        public OrderController(IRepositorie<Order> repositorie)
        {
            OrderRepo = repositorie;
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
            return View();
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
            return View(data);
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
