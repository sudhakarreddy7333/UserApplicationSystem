using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using UserApplicationSystem.BusinessModels;

namespace UserApplicationSystem.Controllers
{
    public class HomeController : Controller
    {
        RelationsModel rmodel = new RelationsModel();
        List<RelationsModel> result = new List<RelationsModel>();
        public HomeController()
        {
            rmodel.UserId = 1;
            rmodel.UserName = "Simran";
            rmodel.MembersRelations = new List<UserFamilyModel>()
            {
                new UserFamilyModel {FirstName="Kamal",Relation=null,MemberId=1},
                new UserFamilyModel {FirstName="Ramesh",Relation=null,MemberId=2},
                new UserFamilyModel {FirstName="Naresh",Relation=null,MemberId=3},
                new UserFamilyModel {FirstName="Samson",Relation=null,MemberId=4}
            };
        }
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CreateApplication()
        {
            UserFamilyModel ufmodel = new UserFamilyModel();
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
            //Redirect to search page only if the user is admin
            return View(rmodel);
        }
        [HttpPost]
        public ActionResult GetOtherMembers(int memberId)
        {
            rmodel.MembersRelations = rmodel.MembersRelations.FindAll(mem => mem.MemberId != memberId);
            rmodel.MembersRelations.ForEach(mem => mem.RelationWithMemberId = memberId);
            
            return PartialView("GetOtherMembers", rmodel);
        }
        [HttpPost]
        public JsonResult MemberRelations(RelationsModel relations)
        {
            return new JsonResult() {
                Data = relations
            }; 
        }

    }
}