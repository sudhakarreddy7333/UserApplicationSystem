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
        public UserFamilyModel FamilyMember { get; set; } = new UserFamilyModel();
        public List<UserFamilyModel> MemberObjs
        {
            get
            {
                return (Session["NewMembers"] as List<UserFamilyModel>) ?? new List<UserFamilyModel>();
            }
        }

        public List<UserFamilyModel> FamilyMembers { get; private set; }

        [HttpGet]
        public ActionResult Index()
        {
            if (TempData["UserId"] != null)
            {
                FamilyMember.UserId = (int)TempData["UserId"];
            }
            return View(FamilyMember);
        }

        [HttpPost]
        [ActionSessionState(System.Web.SessionState.SessionStateBehavior.Required)]
        public ActionResult StoreNewApplication(String submit, UserFamilyModel member)
        {
            if (submit == "Add Member")
            {
                if (ModelState.IsValid)
                {
                    member.MemberId = new Random().Next(10000);
                    MemberObjs.Add(member);
                    Session["NewMembers"] = MemberObjs;
                }
                return View("index");
            }
            else if (submit == "Save and Exit")
            {
                return View("index");
            }
            else if (submit == "Next")
            {
                FamilyMembers = (List<UserFamilyModel>)System.Web.HttpContext.Current.Session["NewMembers"];
                return View("Relationships", FamilyMembers);
            }
            else
                return View();
        }
    }
}