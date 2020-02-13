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
        public ActionResult LibraryUser()
        {
            IEnumerable<User> user = LibraryRepositary.GetUser();
            ViewBag.users = user;
            ViewData["user"] = user;
            TempData["user"] = user;
            return RedirectToAction("LibraryTemp");
        }
        public ActionResult LibraryTemp()
        {
            return View();
        }
    }
}