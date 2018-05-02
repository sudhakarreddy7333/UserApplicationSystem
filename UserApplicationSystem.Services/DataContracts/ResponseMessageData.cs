using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UserApplicationSystem.Services.DataContracts
{
    [DataContract]
    public class ResponseMessageData<T>
    {
        [DataMember]
        public String Message { get; set; }
        [DataMember]
        public T Data { get; set; }
    }
}
