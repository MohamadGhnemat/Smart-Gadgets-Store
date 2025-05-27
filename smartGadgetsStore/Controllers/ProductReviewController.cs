using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using smartGadgetsStore.Models;
using smartGadgetsStore.Models.Repositorie;

namespace smartGadgetsStore.Controllers
{
    public class ProductReviewController : Controller
    {
        IRepositorie<ProductReview> ProductReviewRepo;
        public ProductReviewController(IRepositorie<ProductReview> repositorie)
        {
            ProductReviewRepo = repositorie;
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
            return View();
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
            return View(data);
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
