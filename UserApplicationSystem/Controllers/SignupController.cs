using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using UserApplicationSystem.BusinessModels;
using UserApplicationSystem.UserAccessService;

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
                UserAccessData data = new UserAccessData();
                UserAccessService.UserAccessServiceClient client = new UserAccessService.UserAccessServiceClient();
                data.UserName = user.UserName;
                data.Password = user.Password;
                data.UserType = "User";
                data.Email = user.Email;
                if (client.GetSignupInfo(data).Message == "Success") {
                    return RedirectToAction("index", "login");
                }
                else return RedirectToAction("Signup");

            }
            else
                return RedirectToAction("Signup");
        }
    }
}