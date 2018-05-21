using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UserApplicationSystem.Services.DataContracts
{
    [DataContract]
    public class UserApplicationData
    {
        [DataMember]
        public int ApplicationId { get; set; }
        [DataMember]
        public String ApplicationStatus { get; set; }
        public int UserId { get; set; }
    }
}
