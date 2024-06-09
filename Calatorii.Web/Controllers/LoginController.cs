<<<<<<< HEAD
﻿using System;
using System.Web.Mvc;
using System.Web.Security;
using Calatorii.BusinessLogic;
using Calatorii.BusinessLogic.Interfaces;
using Calatorii.Domain.Entities.User;
using Calatorii.Domain.Entities.User.Responses;
using Calatorii.Web.Models;

namespace Calatorii.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly ISession _session;

        public LoginController()
        {
            var bl = new BussinesLogic();
            _session = bl.GetSessionBL();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserLogin login)
        {
            if (ModelState.IsValid)
            {
                ULoginData data = new ULoginData
                {
                    Credential = login.Credential,
                    Password = login.Password,
                    LoginIp = Request.UserHostAddress,
                    LoginDateTime = DateTime.Now
                };

                ULoginResp userResp = _session.UserLoginAction(data);
                if (userResp.Status)
                {
                    FormsAuthentication.SetAuthCookie(login.Credential, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", userResp.StatusMsg);
                }
            }
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}
=======
﻿using Calatorii.BusinessLogic;
using Calatorii.BusinessLogic.Interfaces;
using Calatorii.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Calatorii.Web.Models;
using Calatorii.Domain.Entities.User.Responses;
using System.Diagnostics;


namespace Calatorii.Web.Controllers
{
     public class LoginController : Controller
     {
          private readonly ISession _session;
          public LoginController()
          {
               var bl = new BussinesLogic();
               _session = bl.GetSessionBL();
          }

          public ActionResult Login()
          {
               return View();
          }

          [HttpPost]
          [ValidateAntiForgeryToken]
          public ActionResult Login(UserLogin login)
          {
               Debug.WriteLine("logare succesiful");
               Debug.WriteLine(login);
               if (ModelState.IsValid)
               {
                    ULoginData data = new ULoginData
                    {
                         Credential = login.Credential,
                         Password = login.Password,
                         LoginIp = Request.UserHostAddress,
                         LoginDateTime = DateTime.Now
                    };

                    ULoginResp userResp = _session.UserLoginAction(data);
                    ViewBag.LogSuccess = userResp.Status;
                    if (userResp.Status)
                    {
                         return RedirectToAction("Login", "Home");
                    }
                    else
                    {
                         ModelState.AddModelError("", userResp.StatusMsg);
                         return View();
                    }
               }
               return RedirectToAction("Login", "Home");
          }
     }
}
>>>>>>> f006cfef8bd9ec470295ed59af47bbd576fe2fa1
