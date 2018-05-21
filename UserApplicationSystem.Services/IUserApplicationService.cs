using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using UserApplicationSystem.Services.DataContracts;

namespace UserApplicationSystem.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserApplicationService" in both code and config file together.
    [ServiceContract]
    public interface IUserApplicationService
    {
        [WebInvoke(ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        Task<ResponseMessageData<UserApplicationData>> GenerateApplicationToken(UserAccessData user);

        [WebInvoke(ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        ResponseMessageData<UserApplicationData> GetApplicationStatus(int applicationId);
    }
}
