using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using smartGadgetsStore.Models;
using smartGadgetsStore.Models.Repositorie;
using smartGadgetsStore.ViewModels;

namespace smartGadgetsStore.Controllers
{
    public class CartItemController : Controller
    {
        IRepositorie<CartItem> CartItemRepo;
        IRepositorie<User> UserRepo;
        IRepositorie<Product> ProductRepo;
        public CartItemController(IRepositorie<CartItem> repositorie, IRepositorie<User> repositorie1, IRepositorie<Product> repositorie2)
        {
            CartItemRepo = repositorie;
            UserRepo = repositorie1;
            ProductRepo = repositorie2;
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
            var obj = new VwCartItemProductUser
            {
                lstProducts = ProductRepo.View().ToList(),
                lstUsers = UserRepo.View().ToList(),
            };
            return View(obj);
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
            var obj = new VwCartItemProductUser
            {
                CartItemID = data.CartItemID,
                UserID = data.UserID,
                ProductID = data.ProductID,
                Quantity = data.Quantity,
                AddedAt = data.AddedAt,
                lstProducts = ProductRepo.View().ToList(),
                lstUsers = UserRepo.View().ToList(),
            };
            return View(obj);
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
