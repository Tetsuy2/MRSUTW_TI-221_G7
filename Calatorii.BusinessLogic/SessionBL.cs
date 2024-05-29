using Calatorii.BusinessLogic.Core;
using Calatorii.BusinessLogic.Interfaces;
using Calatorii.Domain.Entities.User;
using Calatorii.Domain.Entities.User.Responses;
namespace Calatorii.BusinessLogic
{
     public class SessionBL : UserApi, ISession
     {
          public new ULoginResp UserLoginAction(ULoginData _login)
          {
               return base.UserLoginAction(_login);
          }
        public new URegisterResp UserRegisterAction(URegisterData _register) 
        {
            return base.UserRegisterAction(_register);
        }

     }
}
