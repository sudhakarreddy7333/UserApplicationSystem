using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApplicationSystem.Services.DataContracts;
using UserApplicationSystem.Services.Entities;
using UserApplicationSystem.Services.IRepository;

namespace UserApplicationSystem.Services.Repository
{
    class UserMemberRepository : IUserMemberRepository
    {
        public async Task<UserMembersData> AddMember(UserMembersData member)
        {
            using(UAS_SystemEntities dbContext = new UAS_SystemEntities())
            {
                int result = 0;
                List<UAS_Family_Relations> relations = new List<UAS_Family_Relations>();
                RelationsData[] relationsData =  member.RelationsList.ToArray();
                for (int i = 0; i < relationsData.Length && relationsData!= null; i++)
                {
                    relations.Add(new UAS_Family_Relations()
                    {
                        RelativeName = relationsData[i].RelativeName,
                        RelationId = relationsData[i].RelativeId,
                        RelationType = relationsData[i].RelationType,
                        ReverseRelationType = relationsData[i].ReverseRelationType
                    });
                }
   
                UAS_Household_Members members = new UAS_Household_Members() {
                    FirstName = member.FirstName,
                    LastName = member.LastName,
                    MiddleName = member.MiddleName,
                    Dob = member.Dob,
                    Gender = member.Gender,
                    Suffix= member.Suffix,
                    UAS_Family_Relations = relations,
                    UserId = member.UserId
                };
                try
                {
                    dbContext.Set<UAS_Household_Members>().Add(members);
                    result = await dbContext.SaveChangesAsync();
                    dbContext.Dispose();
                    if (result == 1)
                        return member;
                    else return null;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception", e);
                    return null;
                }
                finally
                {
                    dbContext.Dispose();
                }
            }
        }
    }
}
