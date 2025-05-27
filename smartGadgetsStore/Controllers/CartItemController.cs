using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using smartGadgetsStore.Models;
using smartGadgetsStore.Models.Repositorie;

namespace smartGadgetsStore.Controllers
{
    public class CartItemController : Controller
    {
        IRepositorie<CartItem> CartItemRepo;
        public CartItemController(IRepositorie<CartItem> repositorie)
        {
            CartItemRepo = repositorie;
        }
        // GET: CartItemController
        public ActionResult Index()
        {
            var data = CartItemRepo.View().ToList();
            return View(data);
        }

        // GET: CartItemController/Details/5
        public ActionResult Details(int id)
        {
            var data = CartItemRepo.Find(id);
            return View(data);
        }

        // GET: CartItemController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CartItemController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CartItem collection)
        {
            try
            {
                CartItemRepo.Add(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CartItemController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = CartItemRepo.Find(id);
            return View(data);
        }

        // POST: CartItemController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CartItem collection)
        {
            try
            {
                CartItemRepo.Update(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CartItemController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = CartItemRepo.Find(id);
            return View(data);
        }

        // POST: CartItemController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CartItem collection)
        {
            try
            {
                CartItemRepo.Delete(id, collection);    
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
