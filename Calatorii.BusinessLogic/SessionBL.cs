using Calatorii.BusinessLogic.Core;
using Calatorii.BusinessLogic.Interfaces;
using Calatorii.Domain.Entities.User;
using Calatorii.Domain.Entities.User.Responses;
<<<<<<< HEAD

namespace Calatorii.BusinessLogic
{
    public class SessionBL : ISession
    {
        private readonly UserApi _userApi;

        public SessionBL()
        {
            _userApi = new UserApi();
        }

        public ULoginResp UserLoginAction(ULoginData _login)
        {
            return _userApi.UserLoginAction(_login);
        }

        public URegisterResp UserRegisterAction(URegisterData _register)
        {
            return _userApi.UserRegisterAction(_register);
        }
    }
=======
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
>>>>>>> c07de0dcb2c15f00cd2a80f79ac72649b834707e
}
