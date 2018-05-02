using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UserApplicationSystem.Services.DataContracts
{
    [DataContract]
    public class UserAccessData
    {
        [DataMember]
        public String UserName { get; set; }
        [DataMember]
        public String Email { get; set; }
        [DataMember]
        public String Password { get; set; }
        [DataMember]
        public String UserType { get; set; }
    }
}
