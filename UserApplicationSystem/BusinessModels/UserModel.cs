using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserApplicationSystem.BusinessModels
{
    public class UserModel
    {
        [StringLength(50, MinimumLength = 10, ErrorMessage = ConstantsModel.UsernameMinLengthError)]
        public String UserName { get; set; }

        [EmailAddress(ErrorMessage = ConstantsModel.EmailValidationError)]
        public String Email { get; set; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [StringLength(50,MinimumLength =6,ErrorMessage =ConstantsModel.PasswordMinLengthError)]
        public String Password { get; set; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [Compare("Password", ErrorMessage =ConstantsModel.PasswordsDonotMatchError)]
        public String ConfirmPassword { get; set; }

        public String UserType { get; set; }
    }

    public class LoginUserModel
    {
        public String UserName { get; set; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public String Password { get; set; }

        public String LoginStatus { get; set; }
    }
}