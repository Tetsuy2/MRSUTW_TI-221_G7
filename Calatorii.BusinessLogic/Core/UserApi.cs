using Calatorii.BusinessLogic.DBModel;
using Calatorii.Domain.Entities.User.Responses;
using Calatorii.Domain.Entities.User;
using System.Linq;
using System;
<<<<<<< HEAD

namespace Calatorii.BusinessLogic.Core
{
    public class UserApi
    {
        public ULoginResp UserLoginAction(ULoginData data)
        {
            UDbTable user;
            using (var db = new UserContext())
            {
                user = db.Users.FirstOrDefault(u => u.Email == data.Credential && u.Password == data.Password);
            }
            if (user != null)
            {
                return new ULoginResp { Status = true };
            }
            else
            {
                return new ULoginResp { Status = false };
            }
        }

        public URegisterResp UserRegisterAction(URegisterData data)
        {
=======
using System.Diagnostics;

namespace Calatorii.BusinessLogic.Core
{
     public class UserApi
     {
          public ULoginResp UserLoginAction(ULoginData data)
          {
               UDbTable user;
               using (var db = new UserContext())
               {
                    user = db.Users.FirstOrDefault(u => u.Email == data.Credential && u.Password == data.Password);
               }
               if (user != null)
               {
                    return new ULoginResp { Status = true };
               }
               else
               {
                    return new ULoginResp { Status = false };
               }
          }

        public URegisterResp UserRegisterAction(URegisterData data)
        {

>>>>>>> c07de0dcb2c15f00cd2a80f79ac72649b834707e
            UDbTable user;
            using (var db = new UserContext())
            {
                user = db.Users.Create();
                user.Email = data.Email;
                user.Username = data.Credential;
                user.Password = data.Password;
<<<<<<< HEAD
                user.Role = data.Role; // Assign the role

                var result = db.Users.Add(user);
=======

                var result = db.Users.Add(user);

>>>>>>> c07de0dcb2c15f00cd2a80f79ac72649b834707e
                db.SaveChanges();
            }
            if (user != null)
            {
                return new URegisterResp { Status = true };
            }
            else
            {
                return new URegisterResp { Status = false };
            }
        }
    }
}
