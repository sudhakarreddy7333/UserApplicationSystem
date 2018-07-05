using System;
using System.Collections.Generic;
using System.Web.Mvc;
using UserApplicationSystem.BusinessModels;
using UserApplicationSystem.Filters;
using UserApplicationSystem.UserApplicationService;
using UserApplicationSystem.UserMemberService;

namespace UserApplicationSystem.Controllers
{
    public class HomeController : Controller
    { 
        public ActionResult Index(string loggedIn, int? userId)
        {
            if(loggedIn != null) ViewBag.LoggedInAs = loggedIn.Trim();
           
            if (userId>0) TempData["UserId"] = userId;
            return View();
        }
    

        [HttpGet]
        public ActionResult CreateApplication()
        {
            return RedirectToAction("CreateApplication");
        }

    }
}