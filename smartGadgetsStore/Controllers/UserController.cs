using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using smartGadgetsStore.Models;
using smartGadgetsStore.Models.Repositorie;

namespace smartGadgetsStore.Controllers
{
    public class UserController : Controller
    {
        IRepositorie<User> UserRepo;
        public UserController(IRepositorie<User> repositorie)
        {
            UserRepo = repositorie;
        }
        // GET: UserController
        public ActionResult Index()
        {
            var data = UserRepo.View().ToList();
            return View(data);
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            var data = UserRepo.Find(id);
            return View(data);
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User collection)
        {
            try
            {
                UserRepo.Add(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = UserRepo.Find(id);
            return View(data);
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, User collection)
        {
            try
            {
                UserRepo.Update(id , collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = UserRepo.Find(id);
            return View(data);
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, User collection)
        {
            try
            {
                UserRepo.Delete(id ,collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
