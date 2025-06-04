using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using smartGadgetsStore.Models;
using smartGadgetsStore.Models.Repositorie;
using smartGadgetsStore.ViewModels;

namespace smartGadgetsStore.Controllers
{
    public class ProductController : Controller
    {
        IRepositorie<Product> ProductRepo;
        IRepositorie<Category> CategoryRepo;
        IRepositorie<Brand> BrandRepo;
        public ProductController(IRepositorie<Product> repositorie, IRepositorie<Category> repositorie1, IRepositorie<Brand> repositorie2)
        {
            ProductRepo = repositorie;
            CategoryRepo = repositorie1;
            BrandRepo = repositorie2;
        }
        // GET: ProductController
        public ActionResult Index()
        {
            var data = ProductRepo.View().ToList();
            return View(data);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            var data = ProductRepo.Find(id);
            return View(data);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            var obj = new VwProductBrandCategory
            {
                lstBrands = BrandRepo.View().ToList(),
                lstCategories = CategoryRepo.View().ToList(),
            };
            return View(obj);
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product collection)
        {
            try
            {
                ProductRepo.Add(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = ProductRepo.Find(id);
            var obj = new VwProductBrandCategory
            {
                 ProductID = data.ProductID ,
                Name = data.Name ,
                Description = data.Description ,
                QuantityInStock = data.QuantityInStock ,
                Price = data.Price ,
                CreatedAt = data.CreatedAt ,
                ImageURL = data.ImageURL ,
                BrandID = data.BrandID ,
                CategoryID = data.CategoryID ,
                lstBrands = BrandRepo.View().ToList(),
                lstCategories = CategoryRepo.View().ToList(),
            };
            return View(obj);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product collection)
        {
            try
            {
                ProductRepo.Update(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = ProductRepo.Find(id);
            return View(data);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Product collection)
        {
            try
            {
                ProductRepo.Delete(id , collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
