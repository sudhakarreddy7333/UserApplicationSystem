using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserApplicationSystem.BusinessModels;
using UserApplicationSystem.UserAccessService;

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
                UserAccessService.UserAccessServiceClient client = new UserAccessService.UserAccessServiceClient();
                UserAccessData loginData = new UserAccessData();
                loginData.UserName = loginDetails.UserName;
                loginData.Password = loginDetails.Password;
                if(client.AuthenticateUser(loginData).Message == "Success")
                {
                    return RedirectToAction("index", "home");
                }
                else return RedirectToAction("index", "login");


            }
            else
                return RedirectToAction("index", "login");

        }
    }
}