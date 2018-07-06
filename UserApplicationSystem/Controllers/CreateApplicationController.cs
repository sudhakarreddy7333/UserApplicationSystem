using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserApplicationSystem.BusinessModels;
using UserApplicationSystem.Filters;

namespace UserApplicationSystem.Controllers
{
    public class CreateApplicationController : Controller
    {
        #region
        public UserFamilyModel FamilyMember { get; set; } = new UserFamilyModel();
        List<UserFamilyModel> listOfmembers = new List<UserFamilyModel>();
        public List<UserFamilyModel> FamilyMembers { get; private set; }

        #endregion

        [HttpGet]
        public ActionResult Index()
        {
            if (TempData["UserId"] != null)
            {
                FamilyMember.UserId = (int)TempData["UserId"];
            }
            ViewBag.DisplayStatusMsg = "none";
            return View(FamilyMember);
        }

        [HttpParam]
        [ActionSessionState(System.Web.SessionState.SessionStateBehavior.Required)]
        public ActionResult StoreNewApplication(UserFamilyModel member)
        {
            if (ModelState.IsValid)
            {
                member.MemberId = new Random().Next(10000);
                if (Session["NewMembers"] != null)
                {
                    listOfmembers = (List<UserFamilyModel>)System.Web.HttpContext.Current.Session["NewMembers"];
                    listOfmembers.Add(member);
                }
                else
                {
                    listOfmembers.Add(member);
                }
                System.Web.HttpContext.Current.Session["NewMembers"] = listOfmembers;
                ViewBag.StatusMessage = listOfmembers.Count+" Member(s) added";
                ViewBag.DisplayStatusMsg = "block";
                member = new UserFamilyModel();
                return View("index", member);
            }
           
            return View("index", member);
        }
        [HttpParam]
        public ActionResult CreateAppNextBtn_Click()
        {
            FamilyMembers = (List<UserFamilyModel>)System.Web.HttpContext.Current.Session["NewMembers"];
            if (FamilyMembers.Count > 0)
            {
                return RedirectToAction("index", "Relations");
            }
            else
            {
                return RedirectToAction("index");
            }
        }
    }
}