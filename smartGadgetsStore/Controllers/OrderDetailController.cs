using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using smartGadgetsStore.Models;
using smartGadgetsStore.Models.Repositorie;

namespace smartGadgetsStore.Controllers
{
    public class OrderDetailController : Controller
    {
        IRepositorie<OrderDetail> OrderDetailRepo;
        public OrderDetailController(IRepositorie<OrderDetail> repositorie)
        {
         OrderDetailRepo = repositorie;   
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
            return View();
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
            return View(data);
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
