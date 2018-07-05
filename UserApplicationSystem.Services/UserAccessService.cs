using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using UserApplicationSystem.Services.DataContracts;
using UserApplicationSystem.Services.IRepository;
using UserApplicationSystem.Services.Repository;

namespace UserApplicationSystem.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class UserAccessService : IUserAccessService
    {
        UserAccessRepository userRepo = new UserAccessRepository();
        ResponseMessageData<UserAccessData> response = new ResponseMessageData<UserAccessData>();
        public ResponseMessageData<UserAccessData> AuthenticateUser(UserAccessData loginInfo)
        {
            if(loginInfo != null)
            {
                UserAccessData result = userRepo.UserLogin(loginInfo);
                if(result.UserName != null)
                {
                    response = new ResponseMessageData<UserAccessData>()
                    {
                        Data = result,
                        Message = "Success"
                    };
                }
                else
                {
                    response = new ResponseMessageData<UserAccessData>()
                    {
                        Data = null,
                        Message = "NoUserFound"
                    };
                }
                return response;
            }
            else
            {
                response = new ResponseMessageData<UserAccessData>()
                {
                    Data = null,
                    Message = "NoData"
                };
                return response;
            }
        }

        public ResponseMessageData<UserAccessData> GetSignupInfo(UserAccessData signupInfo)
        {
            if(signupInfo != null)
            {
                response = new ResponseMessageData<UserAccessData>()
                {
                    Data = userRepo.UserSignup(signupInfo).Result,
                    Message = "Success"
                };
                return response;
            }
            else
            {
                response = new ResponseMessageData<UserAccessData>()
                {
                    Data = null,
                    Message = "NoData"
                };
                return response;
            }
        }
    }
}
