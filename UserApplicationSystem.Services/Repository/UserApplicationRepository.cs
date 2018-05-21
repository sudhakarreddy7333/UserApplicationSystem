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
    public class UserApplicationRepository : IUserApplicationRepository
    {
        public UserApplicationData GetApplicationStatus(int applicationId)
        {
           using(UAS_SystemEntities dbContext = new UAS_SystemEntities())
            {
                try
                {
                    UAS_Applicants retrivedApplication = dbContext.UAS_Applicants.SingleOrDefault(application => application.AplicantId == applicationId);
                    if (retrivedApplication != null)
                    {
                        return new UserApplicationData()
                        {
                            ApplicationId = retrivedApplication.AplicantId,
                            ApplicationStatus = retrivedApplication.AppStatus
                        };
                    }
                    else
                        return new UserApplicationData() { };
                }
                catch(Exception e)
                {
                    Console.WriteLine("Exception occured", e);
                    return null;
                }
            }
        }

        public async Task<UserApplicationData> StoreApplication(UserApplicationData newApplication)
        {
            int result = 0;
            using (UAS_SystemEntities dbContext = new UAS_SystemEntities())
            {
                try
                {
                    dbContext.Set<UAS_Applicants>().Add(new UAS_Applicants()
                    {
                        AplicantId = newApplication.ApplicationId,
                        AppStatus = newApplication.ApplicationStatus,
                        UserId = newApplication.UserId
                    });
                    result = await dbContext.SaveChangesAsync();
                    dbContext.Dispose();
                    if(result == 1)
                        return newApplication;
                    else return null;
                }
                catch(Exception e)
                {
                    Console.WriteLine("Exception occured", e);
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
