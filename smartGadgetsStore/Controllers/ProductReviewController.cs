using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using smartGadgetsStore.Models;
using smartGadgetsStore.Models.Repositorie;
using smartGadgetsStore.ViewModels;

namespace smartGadgetsStore.Controllers
{
    public class ProductReviewController : Controller
    {
        IRepositorie<ProductReview> ProductReviewRepo;
        IRepositorie<Product> ProductRepo;
        IRepositorie<User> UserRepo;
        public ProductReviewController(IRepositorie<ProductReview> repositorie , IRepositorie<Product> repositorie1, IRepositorie<User> repositorie2)
        {
            ProductReviewRepo = repositorie;
            ProductRepo = repositorie1;
            UserRepo = repositorie2;
        }
        // GET: ProductReviewController
        public ActionResult Index()
        {
            var data = ProductReviewRepo.View().ToList();
            return View(data);
        }

        // GET: ProductReviewController/Details/5
        public ActionResult Details(int id)
        {
            var data = ProductReviewRepo.Find(id);
            return View(data);
        }

        // GET: ProductReviewController/Create
        public ActionResult Create()
        {
            var obj = new VwProductReviewUserProduct
            {
               lstProducts = ProductRepo.View().ToList(),
               lstUsers = UserRepo.View().ToList(),
            };
            return View(obj);
        }

        // POST: ProductReviewController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductReview collection)
        {
            try
            {
                ProductReviewRepo.Add(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductReviewController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = ProductReviewRepo.Find(id);
            var obj = new VwProductReviewUserProduct
            {
                ProductReviewID = data.ProductReviewID,
                ProductID = data.ProductID,
                UserID = data.UserID,
                CreatedAt = data.CreatedAt,
                Rating = data.Rating,
                ReviewText=data.ReviewText,
                lstProducts = ProductRepo.View().ToList(),
                lstUsers = UserRepo.View().ToList(),
            };
            return View(obj);
        }

        // POST: ProductReviewController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProductReview collection)
        {
            try
            {
                ProductReviewRepo.Update(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductReviewController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = ProductReviewRepo.Find(id);
            return View(data);
        }

        // POST: ProductReviewController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,ProductReview collection)
        {
            try
            {
                ProductReviewRepo.Delete(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
