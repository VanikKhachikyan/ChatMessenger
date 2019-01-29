﻿using ChatMessenger.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChatMessenger.Core.Models.Cache.Presentation.Register
{
    public class UserRegisterModelIn
    {
        [Required(ErrorMessage = Constants.CustomErrors.EmptyEmailErrorMessage)]
        [EmailAddress(ErrorMessage = Constants.CustomErrors.EmailFormatErrorMessage)]
        public string Email { get; set; }

        [Required(ErrorMessage = Constants.CustomErrors.EmptyPasswordErrorMessage)]
        [DataType(DataType.Password, ErrorMessage = Constants.CustomErrors.InvalidPasswordErrorMessage)]
        public string Password { get; set; }

        [Required(ErrorMessage = Constants.CustomErrors.EmptyConfirmPasswordErrorMessage)]
        [DataType(DataType.Password, ErrorMessage = Constants.CustomErrors.InvalidPasswordErrorMessage)]
        [Compare(nameof(Password), ErrorMessage = Constants.CustomErrors.PasswordMatchErrorMessage)]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage = Constants.CustomErrors.PhoneNumberFormatErrorMessage)]
        public string PhoneNumber { get; set; }
    }
}
