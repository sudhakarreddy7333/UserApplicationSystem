using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UserApplicationSystem.Services.DataContracts
{
    [DataContract]
    public class RelationsData
    {
        [DataMember]
        public int RelativeId { get; set; }

        [DataMember]
        public String RelativeName { get; set; }

        [DataMember]
        public String RelationType { get; set; }

        [DataMember]
        public String ReverseRelationType { get; set; }
    }
}
