using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserApplicationSystem.BusinessModels
{
    public static class ConstantsModel
    {
        public const String UsernameMinLengthError = "Username should have atleast 6 characters";
        public const String EmailValidationError = "Please enter valid email address";
        public const String PasswordMinLengthError = "Password should be atleast 6 characters long";
        public const String PasswordsDonotMatchError = "Passwords do not match";
        public const String SuccessMessage = "Success";
    }
}