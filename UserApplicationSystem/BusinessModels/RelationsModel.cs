using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserApplicationSystem.BusinessModels
{
    public class RelationsModel
    {
        public int UserId { get; set; }
        public String UserName { get; set; }
        public List<UserFamilyModel> MembersRelations { get; set; }
    }

}