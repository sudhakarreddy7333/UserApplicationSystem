using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using UserApplicationSystem.BusinessModels;
using UserApplicationSystem.Filters;
using WebGrease.Css.Extensions;

namespace UserApplicationSystem.Controllers
{
    public class HomeController : Controller
    {
        List<UserFamilyModel> familyMembers= new List<UserFamilyModel>();
        public List<UserFamilyModel> MemberObjs {
            get
            {
                return (Session["NewMembers"] as List<UserFamilyModel>) ?? new List<UserFamilyModel>();
            }
        }
        public HomeController()
        {
        }
        
        public ActionResult Index(string loggedIn)
        {
            if(loggedIn != null) ViewBag.LoggedInAs = loggedIn.Trim();
            return View();
        }
        [HttpGet]
        public ActionResult CreateApplication()
        {
            return View();
        }
        [HttpPost]
        [ActionSessionState(System.Web.SessionState.SessionStateBehavior.Required)]
        public ActionResult CreateApplication(String submit ,UserFamilyModel member)
        {
            if(submit == "Add Member") {
                if (ModelState.IsValid)
                {
                    member.MemberId = new Random().Next(10000);
                    MemberObjs.Add(member);
                    Session["NewMembers"] = MemberObjs;
                }
                return View("CreateApplication");
            }
            else if(submit == "Save and Exit")
            {
                return View("index");
            }
            else if(submit == "Next")
            {
                familyMembers = (List<UserFamilyModel>)System.Web.HttpContext.Current.Session["NewMembers"];
                return View("Relationships", familyMembers);
            }
            else
                return View();
        }
        [HttpGet]
        public ActionResult SearchApplication()
        {
            //Redirect to search page only if the user is admin
            return View();
        }
        
        [HttpGet]
        public ActionResult Relationships()
        {
            return View(familyMembers);
        }
        [HttpPost]
        public ActionResult GetOtherMembers(int memberId)
        {
            familyMembers = (List<UserFamilyModel>)System.Web.HttpContext.Current.Session["NewMembers"];
            int index = familyMembers.FindIndex(mem => mem.MemberId == memberId);
            familyMembers[index].RelationsList = new List<RelationsModel>();
            familyMembers.FindAll(mem => mem.MemberId != memberId)
                .ForEach(oMem =>
                {
                    familyMembers[index].RelationsList.Add(
                        new RelationsModel()
                            {
                                RelationType = null,
                                RelativeName = oMem.FirstName,
                                ReverseRelationType = null,
                                RelativeId = oMem.MemberId
                            }
                        );
                });
            return PartialView("GetOtherMembers", familyMembers[index]);
        }
        [HttpPost]
        public JsonResult MemberRelations(UserFamilyModel relations)
        {
            return new JsonResult() {
                Data = relations
            }; 
        }

    }
}