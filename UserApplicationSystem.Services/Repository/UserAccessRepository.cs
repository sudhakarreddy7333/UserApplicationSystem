using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApplicationSystem.Services.DataContracts;
using UserApplicationSystem.Services.IRepository;
using UserApplicationSystem.Services.Entities;

namespace UserApplicationSystem.Services.Repository
{
    class UserAccessRepository : IUserAccessRepository
    {
        public async Task<UserAccessData> UserSignup(UserAccessData loginDetails)
        {
            using (UAS_SystemEntities db = new UAS_SystemEntities())
            {
                int result = 0;
                UAS_User_Details signup = new UAS_User_Details();
                signup.UserName = loginDetails.UserName;
                signup.UserType = loginDetails.UserType;
                signup.Email = loginDetails.Email;
                signup.Upassword = loginDetails.Password;
                try
                {
                    db.Set<UAS_User_Details>().Add(signup);
                    result = await db.SaveChangesAsync();
                    db.Dispose();
                    if (result == 1)
                        return loginDetails;
                    else return null;
                }
                catch(Exception e)
                {
                    Console.WriteLine("Exception", e);
                    return null;
                }
                finally
                {
                    db.Dispose();
                }
            }
        } 

        public String UserLogin(UserAccessData userDetails)
        {
            using (UAS_SystemEntities dbContext = new UAS_SystemEntities())
            {
                //var query = from c in db.UAS_User_Details
                //            where 
                //            c.UserName == userDetails.UserName && c.Upassword == userDetails.Password
                //            select
                UAS_User_Details retrivedUser = dbContext.UAS_User_Details.SingleOrDefault(user => user.UserName == userDetails.UserName && user.Upassword == userDetails.Password);
                if (retrivedUser != null)
                {
                    return "UserFound";
                }
                else
                    return "UserNotFound";
            }     
        }
    }
}
