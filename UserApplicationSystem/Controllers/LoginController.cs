using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserApplicationSystem.BusinessModels;

namespace UserApplicationSystem.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public RedirectToRouteResult Index(LoginUserModel loginDetails)
        {
            if (ModelState.IsValid)
            {
                //if (AuthenticateUser(loginDetails))
                //{
                //    return RedirectToAction("index","home");
                //}
                //else
                //{
                //    loginDetails.LoginStatus = "Incorrect username or password entered";
                //    return RedirectToAction("index","login");
                //}
                return RedirectToAction("index", "home");
            }
            else
                return RedirectToAction("index", "login");

        }
        public bool AuthenticateUser(LoginUserModel loginDetails)
        {
            if (loginDetails.UserName == "raju" && loginDetails.Password == "raju") return true;
            else return false;
        }
    }
}