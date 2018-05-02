using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace UserApplicationSystem.BusinessModels
{
    public class UserFamilyModel
    {
        [StringLength(50, MinimumLength = 10, ErrorMessage = ConstantsModel.UsernameMinLengthError)]
        public String FirstName { get; set; }
            public String LastName { get; set; }
            public String MiddleName { get; set; }
            public String Suffix { get; set; }
            public String Email { get; set; }
            public String Gender { get; set; }
            public DateTime Dob { get; set; }
            public string Relation { get; set; }
            public int UserId { get; set; }
            public int MemberId { get; set; }
            public int RelationWithMemberId { get; set; }
    }
}