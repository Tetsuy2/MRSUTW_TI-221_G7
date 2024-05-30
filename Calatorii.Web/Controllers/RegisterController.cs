using Calatorii.BusinessLogic;
using Calatorii.BusinessLogic.Interfaces;
using Calatorii.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Calatorii.Web.Models;


namespace Calatorii.Web.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ISession _session;
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
        public ActionResult Register(UserRegister register)
        {
            if (ModelState.IsValid)
            {
                URegisterData data = new URegisterData
                {
                    Credential = register.Credential,
                    Password = register.Password,
                    Email = register.Email,
                    RegisterIp = Request.UserHostAddress,
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