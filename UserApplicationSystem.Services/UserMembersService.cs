using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using UserApplicationSystem.Services.DataContracts;
using UserApplicationSystem.Services.Repository;

namespace UserApplicationSystem.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserMembersService" in both code and config file together.
    public class UserMembersService : IUserMembersService
    {
        UserMemberRepository memberRepo = new UserMemberRepository();
        ResponseMessageData<UserMembersData> response = new ResponseMessageData<UserMembersData>();
        public UserMembersService()
        {
            
        }
        public ResponseMessageData<UserMembersData> AddMember(UserMembersData member)
        {
          
            if (member != null)
            {
                UserMembersData result = memberRepo.AddMember(member).Result;
                response = new ResponseMessageData<UserMembersData>()
                {
                    Data = result,
                    Message = "Success"
                };
                return response;
            }
            else
            {
                response = new ResponseMessageData<UserMembersData>()
                {
                    Data = null,
                    Message = "NoData"
                };
                return response;
            }
        }

        public ResponseMessageData<List<UserMembersData>> GetMembers()
        {
            return new ResponseMessageData<List<UserMembersData>>();
        }
    }
}
