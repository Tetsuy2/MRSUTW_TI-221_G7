using Calatorii.BusinessLogic.Core;
using Calatorii.BusinessLogic.Interfaces;
using Calatorii.Domain.Entities.User;
using Calatorii.Domain.Entities.User.Responses;

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
}
