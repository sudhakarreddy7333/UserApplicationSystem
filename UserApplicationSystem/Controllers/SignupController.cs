using System.Web.Mvc;
using UserApplicationSystem.BusinessModels;
using UserApplicationSystem.UserAccessService;

namespace UserApplicationSystem.Controllers
{
    public class SignupController : Controller
    {
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
                UserAccessServiceClient client = new UserAccessServiceClient();
                var response = client.GetSignupInfo(new UserAccessData() {
                    UserName = user.UserName,
                    Password = user.Password,
                    UserType = "User".Trim(),
                    Email = user.Email
                });
                if (response.Message == ConstantsModel.SuccessMessage) {
                    return RedirectToAction("index", "login");
                }
                else return RedirectToAction("Signup");
            }
            else
                return RedirectToAction("Signup");
        }
    }
}