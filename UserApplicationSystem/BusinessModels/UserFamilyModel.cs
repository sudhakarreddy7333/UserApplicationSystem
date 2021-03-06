﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace UserApplicationSystem.BusinessModels
{
    public class UserFamilyModel
    {
        [Required]
        [StringLength(10,ErrorMessage ="Firstname cannot be more than 10 characters")]
        public String FirstName { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "lastname cannot be more than 10 characters")]
        public String LastName { get; set; }

        [StringLength(10, ErrorMessage = "Middle cannot be more than 10 characters")]
        public String MiddleName { get; set; }

        public String Suffix { get; set; }

        [EmailAddress(ErrorMessage ="Please enter a valid Email address")]
        public String Email { get; set; }

        [Required]
        public String Gender { get; set; }

        [Required]
        public DateTime Dob { get; set; }

        public int UserId { get; set; }

        public int MemberId { get; set; }

        public List<RelationsModel> RelationsList { get; set; }

        public String StatusMessage { get; set; }
    }
}