using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserApplicationSystem.BusinessModels;

namespace UserApplicationSystem.Controllers
{
    public class SignupController : Controller
    {
        // GET: Signup
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public RedirectToRouteResult Index(UserModel user)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("index","login");
            }
            else
                return RedirectToAction("Signup");
        }
    }
}