using Calatorii.Domain.Entities.User;
using Calatorii.Domain.Entities.User.Responses;

namespace Calatorii.BusinessLogic.Interfaces
{
<<<<<<< HEAD
    public interface ISession
    {
        ULoginResp UserLoginAction(ULoginData data);
=======
     public interface ISession
     {
          ULoginResp UserLoginAction(ULoginData data);
>>>>>>> c07de0dcb2c15f00cd2a80f79ac72649b834707e
        URegisterResp UserRegisterAction(URegisterData data);
    }
}
