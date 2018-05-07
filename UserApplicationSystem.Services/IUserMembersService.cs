using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using UserApplicationSystem.Services.DataContracts;

namespace UserApplicationSystem.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserMembersService" in both code and config file together.
    [ServiceContract]
    public interface IUserMembersService
    {
        [WebInvoke(ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        ResponseMessageData<UserMembersData> AddMember(UserMembersData member);

        [WebInvoke(ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        ResponseMessageData<List<UserMembersData>> GetMembers();
    }
}
