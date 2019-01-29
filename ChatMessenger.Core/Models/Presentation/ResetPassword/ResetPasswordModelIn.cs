using ChatMessenger.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChatMessenger.Core.Models.Cache.Presentation.ResetPassword
{
    public class ResetPasswordModelIn
    {
        [Required(ErrorMessage = Constants.CustomErrors.EmptyPasswordErrorMessage)]
        [DataType(DataType.Password, ErrorMessage = Constants.CustomErrors.InvalidPasswordErrorMessage)]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = Constants.CustomErrors.EmptyPasswordErrorMessage)]
        [DataType(DataType.Password, ErrorMessage = Constants.CustomErrors.InvalidPasswordErrorMessage)]
        public string Password { get; set; }

        [Required(ErrorMessage = Constants.CustomErrors.EmptyConfirmPasswordErrorMessage)]
        [DataType(DataType.Password, ErrorMessage = Constants.CustomErrors.InvalidPasswordErrorMessage)]
        [Compare(nameof(Password), ErrorMessage = Constants.CustomErrors.PasswordMatchErrorMessage)]
        public string ConfirmPassword { get; set; }
    }
}
