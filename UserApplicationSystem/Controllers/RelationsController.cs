using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserApplicationSystem.BusinessModels;
using UserApplicationSystem.UserMemberService;

namespace UserApplicationSystem.Controllers
{
    public class RelationsController : Controller
    {
        public List<UserFamilyModel> FamilyMembers { get; private set; }

        // GET: Relations
        public ActionResult Index()
        {
            FamilyMembers = (List<UserFamilyModel>)System.Web.HttpContext.Current.Session["NewMembers"];
            return View(FamilyMembers);
        }

        [HttpPost]
        public ActionResult GetOtherMembers(int memberId)
        {
            FamilyMembers = (List<UserFamilyModel>)System.Web.HttpContext.Current.Session["NewMembers"];
            int index = FamilyMembers.FindIndex(mem => mem.MemberId == memberId);
            FamilyMembers[index].RelationsList = new List<RelationsModel>();
            FamilyMembers.FindAll(mem => mem.MemberId != memberId)
                .ForEach(oMem =>
                {
                    FamilyMembers[index].RelationsList.Add(
                        new RelationsModel()
                        {
                            RelationType = null,
                            RelativeName = oMem.FirstName,
                            ReverseRelationType = null,
                            RelativeId = oMem.MemberId
                        }
                        );
                });
            return PartialView("GetOtherMembers", FamilyMembers[index]);
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
            var responseFromClient = client.AddMember(MemberData(relations, relatnsData));
            if (responseFromClient.Message == "Success")
            {
                TempData["NewApplication"] = relations.UserId;
                return RedirectToAction("index","UserApplication");
            }


            else
                return View();
        }

        private static UserMembersData MemberData(UserFamilyModel relations, RelationsData[] relatnsData)
        {
            return new UserMembersData()
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
            };
        }
    }
}