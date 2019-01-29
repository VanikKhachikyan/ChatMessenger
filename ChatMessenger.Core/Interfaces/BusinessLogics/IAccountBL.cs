using ChatMessenger.Core.Models.Cache.Presentation;
using ChatMessenger.Core.Models.Cache.Presentation.LogIn;
using ChatMessenger.Core.Models.Cache.Presentation.LogOut;
using ChatMessenger.Core.Models.Cache.Presentation.Register;
using ChatMessenger.Core.Models.Cache.Presentation.ResetPassword;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChatMessenger.Core.Interfaces.BusinessLogics
{
    public interface IAccountBL
    {
        Task CheckingEmailExists(string email, UserRegisterModelOut response);
        Task Register(UserModel userModel, UserRegisterModelOut response);
        Task<UserLogInModelOut> LogIn(UserLoginModelIn modelIn, UserTokenSessionModel userTokenSessionModel);
        Task ChangePassword(string token, string oldPassword, string newPassword, ResetPasswordModelOut response);
        Task LogOut(string token, UserLogOutModelOut response);
    }
}
