using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using smartGadgetsStore.Models;
using smartGadgetsStore.Models.Repositorie;

namespace smartGadgetsStore.Controllers
{
    public class BrandController : Controller
    {
         IRepositorie<Brand> BrandRepo;
        public BrandController(IRepositorie<Brand> repositorie)
        {
           BrandRepo = repositorie;
        }
        // GET: BrandController
        public ActionResult Index()
        {
            var data = BrandRepo.View().ToList();
            return View(data);
        }

        // GET: BrandController/Details/5
        public ActionResult Details(int id)
        {
            var data = BrandRepo.Find(id);
            return View(data);
        }

        // GET: BrandController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BrandController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Brand collection)
        {
            try
            {
                BrandRepo.Add(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BrandController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = BrandRepo.Find(id);
            return View(data);
        }

        // POST: BrandController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Brand collection)
        {
            try
            {
                BrandRepo.Update(id , collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BrandController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = BrandRepo.Find(id);
            return View(data);
        }

        // POST: BrandController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Brand collection)
        {
            try
            {
                BrandRepo.Delete(id , collection );
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
