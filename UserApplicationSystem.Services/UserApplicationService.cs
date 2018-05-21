using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using UserApplicationSystem.Services.DataContracts;
using UserApplicationSystem.Services.Repository;

namespace UserApplicationSystem.Services
{
    public class UserApplicationService : IUserApplicationService
    {
        UserApplicationRepository appRepo = new UserApplicationRepository();
        public async Task<ResponseMessageData<UserApplicationData>> GenerateApplicationToken(UserAccessData user)
        {
            Random generator = new Random();
            int applicationId = generator.Next(200, 20000);
            UserApplicationData applicationData = new UserApplicationData() {
                ApplicationId = applicationId,
                ApplicationStatus = "Pending",
                UserId = user.UserId
            };
            UserApplicationData result = await appRepo.StoreApplication(applicationData);
            return new ResponseMessageData<UserApplicationData>()
            {
                Message = "Success",
                Data = result
            };
        }

        public ResponseMessageData<UserApplicationData> GetApplicationStatus(int applicationId)
        {
            UserApplicationData appData =  appRepo.GetApplicationStatus(applicationId);
            return new ResponseMessageData<UserApplicationData>() {
                Message = "Success",
                Data = appData
            };
        }
    }
}
