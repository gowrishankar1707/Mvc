using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserEntity;
using UserRepositary;
using System.Web.Mvc;

namespace MVCSample.Controllers
{
    public class LibraryUserController : Controller
    {
        // GET: LibraryUser
        LibraryRepositary repositary;
        
        public LibraryUserController()
        {
            repositary = new LibraryRepositary();
        }
        
        public ActionResult LibraryUser()
        {
            IEnumerable<User> user = LibraryRepositary.GetUser();
            ViewBag.users = user;
            ViewData["user"] = user;
            TempData["user"] = user;
            return View();
        }
        public ActionResult LibraryTemp()
        {
            ViewBag.user = TempData["user"];
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(User user)
        {
            repositary.AddUser(user);
            TempData["Message"] = "User Added";
            return RedirectToAction("LibraryUser");
        }
        public ActionResult Edit(string userName)
        {
            User user = repositary.GetUserByUserName(userName);
            return View(user);
        }
        public ActionResult Update(User user)
        {
            repositary.UpdateUser(user);
            TempData["Message"] = "Package Updated";
            return RedirectToAction("LibraryUser");
        }
        public ActionResult Delete(string userName)
        {
            repositary.DeleteUser(userName);
            return RedirectToAction("LibraryUser");
        }
    }


}
