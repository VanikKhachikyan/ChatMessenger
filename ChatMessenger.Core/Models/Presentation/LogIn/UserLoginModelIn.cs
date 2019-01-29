using ChatMessenger.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChatMessenger.Core.Models.Cache.Presentation.LogIn
{
    public class UserLoginModelIn
    {
        [Required(ErrorMessage = Constants.CustomErrors.EmptyEmailErrorMessage)]
        [DataType(DataType.EmailAddress, ErrorMessage = Constants.CustomErrors.EmailFormatErrorMessage)]
        public string Email { get; set; }

        [Required(ErrorMessage = Constants.CustomErrors.EmptyPasswordErrorMessage)]
        [DataType(DataType.Password, ErrorMessage = Constants.CustomErrors.InvalidPasswordErrorMessage)]
        public string Password { get; set; }
    }
}
