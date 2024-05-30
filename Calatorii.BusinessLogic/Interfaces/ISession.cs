using Calatorii.Domain.Entities.User;
using Calatorii.Domain.Entities.User.Responses;

namespace Calatorii.BusinessLogic.Interfaces
{
     public interface ISession
     {
          ULoginResp UserLoginAction(ULoginData data);
        URegisterResp UserRegisterAction(URegisterData data);
    }
}
