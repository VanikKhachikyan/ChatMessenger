using ChatMessenger.Core.Models.Cache.Presentation.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatMessenger.Core.Models.Cache.Presentation.LogIn
{
    public class UserLogInModelOut : BaseResponseModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public bool EmailIsVerified { get; set; }
        public string PhoneNumber { get; set; }
        public string Token { get; set; }
    }
}
