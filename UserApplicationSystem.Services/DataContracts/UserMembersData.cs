using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UserApplicationSystem.Services.DataContracts
{
    [DataContract]
    public class UserMembersData
    {
        [DataMember]
        public String FirstName { get; set; }

        [DataMember]
        public String LastName { get; set; }

        [DataMember]
        public String MiddleName { get; set; }

        [DataMember]
        public String Suffix { get; set; }

        [DataMember]
        public String Email { get; set; }

        [DataMember]
        public String Gender { get; set; }

        [DataMember]
        public DateTime Dob { get; set; }

        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public int MemberId { get; set; }

        [DataMember]
        public List<RelationsData> RelationsList { get; set; }
    }
}
