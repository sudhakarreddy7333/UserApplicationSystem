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
        List<UserFamilyModel> familyMembers= new List<UserFamilyModel>();
        UserFamilyModel familyMember = new UserFamilyModel();
        public List<UserFamilyModel> MemberObjs {
            get
            {
                return (Session["NewMembers"] as List<UserFamilyModel>) ?? new List<UserFamilyModel>();
            }
        }
        public HomeController()
        {
        }
        
        public ActionResult Index(string loggedIn, int userId)
        {
            if(loggedIn != null) ViewBag.LoggedInAs = loggedIn.Trim();
           
            if (userId>0) TempData["UserId"] = userId;
            return View();
        }
        [HttpGet]
        public ActionResult CreateApplication()
        {
            familyMember.UserId = (int)TempData["UserId"];
            return View(familyMember);
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
        public ActionResult MemberRelations(UserFamilyModel relations)
        {
            UserMembersServiceClient client = new UserMembersServiceClient();
            RelationsModel[] rmodel = relations.RelationsList.ToArray();
            RelationsData[] relatnsData = new RelationsData[rmodel.Length];
            for (int i = 0; i < rmodel.Length; i++)
            {
                relatnsData[i] = new RelationsData
                {
                    RelativeId = rmodel[i].RelativeId,
                    RelativeName = rmodel[i].RelativeName,
                    RelationType = rmodel[i].RelationType,
                    ReverseRelationType = rmodel[i].ReverseRelationType
                };
            }
            var responseFromClient = client.AddMember(new UserMembersData()
            {
                FirstName = relations.FirstName,
                MiddleName = relations.MiddleName,
                LastName = relations.LastName,
                Suffix = relations.Suffix,
                Gender = relations.Gender,
                Dob = relations.Dob,
                Email = relations.Email,
                UserId = relations.UserId,
                MemberId = relations.MemberId,
                RelationsList = relatnsData
            });
            if (responseFromClient.Message == "Success")
            {
                TempData["NewApplication"] = GenerateApplicationToken(relations.UserId);
                return RedirectToAction("UserApplication");
            }


            else
                return View();
        }

        public ActionResult UserApplication()
        {
            UserApplicationData applicationData = (UserApplicationData)TempData["NewApplication"];
            ApplicantModel appModel = new ApplicantModel()
            {
                AplicantId = applicationData.ApplicationId,
                Status = applicationData.ApplicationStatus
            };
            return View(appModel);
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