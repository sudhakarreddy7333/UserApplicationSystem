using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApplicationSystem.Services.DataContracts;


namespace UserApplicationSystem.Services.IRepository
{
    interface IUserAccessRepository
    {
        Task<UserAccessData> UserSignup(UserAccessData userDetails);
        UserAccessData UserLogin(UserAccessData loginDetails);
    }
}
