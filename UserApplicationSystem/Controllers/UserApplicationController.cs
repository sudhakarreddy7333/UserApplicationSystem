using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserApplicationSystem.BusinessModels;
using UserApplicationSystem.UserApplicationService;

namespace UserApplicationSystem.Controllers
{
    public class UserApplicationController : Controller
    {
        // GET: UserApplication
        public ActionResult Index()
        {
            int userId;
            if (TempData.ContainsKey("NewApplication"))
            {
                userId = (int)TempData["NewApplication"];
                UserApplicationData applicationData = GenerateApplicationToken(userId);
                ApplicantModel appModel = new ApplicantModel()
                {
                    AplicantId = applicationData.ApplicationId,
                    Status = applicationData.ApplicationStatus
                };
                return View(appModel);
            }
            return View();
        }

        private UserApplicationData GenerateApplicationToken(int userId)
        {
            UserApplicationServiceClient appClient = new UserApplicationServiceClient();
            var newApplicationResponse = appClient.GenerateApplicationToken(new UserAccessData()
            {
                UserId = userId
            });
            if (newApplicationResponse.Message == "Success")
            {
                return newApplicationResponse.Data;
            }
            else
            {
                return null;
            }
        }
    }
}