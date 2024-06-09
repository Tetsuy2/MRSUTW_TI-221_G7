<<<<<<< HEAD
﻿using System;
using System.Web.Mvc;
using System.Web.Security;
using Calatorii.BusinessLogic;
using Calatorii.BusinessLogic.Interfaces;
using Calatorii.Domain.Entities.User;
using Calatorii.Web.Models;

=======
﻿using Calatorii.BusinessLogic;
using Calatorii.BusinessLogic.Interfaces;
using Calatorii.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Calatorii.Web.Models;


>>>>>>> f006cfef8bd9ec470295ed59af47bbd576fe2fa1
namespace Calatorii.Web.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ISession _session;
<<<<<<< HEAD

=======
>>>>>>> f006cfef8bd9ec470295ed59af47bbd576fe2fa1
        public RegisterController()
        {
            var bl = new BussinesLogic();
            _session = bl.GetSessionBL();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public ActionResult Register(UserRegister register, string Role)
=======
        public ActionResult Register(UserRegister register)
>>>>>>> f006cfef8bd9ec470295ed59af47bbd576fe2fa1
        {
            if (ModelState.IsValid)
            {
                URegisterData data = new URegisterData
                {
                    Credential = register.Credential,
                    Password = register.Password,
                    Email = register.Email,
                    RegisterIp = Request.UserHostAddress,
<<<<<<< HEAD
                    RegisterDateTime = DateTime.Now,
                    Role = Role // Capture the role
                };

                var userRegister = _session.UserRegisterAction(data);
                if (userRegister.Status)
                {
                    FormsAuthentication.SetAuthCookie(register.Credential, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", userRegister.StatusMsg);
                }
            }
            return View();
        }
    }
}
=======
                    RegisterDateTime = DateTime.Now
                };

               var userRegister = _session.UserRegisterAction(data);
                if (userRegister.Status)
                {
                     return RedirectToAction("Register", "Home");
                }
                else
                {
                     ModelState.AddModelError("", userRegister.StatusMsg);
                     return View();
                }
            }
            return RedirectToAction("Register", "Home");
        }
    }
}
>>>>>>> f006cfef8bd9ec470295ed59af47bbd576fe2fa1
