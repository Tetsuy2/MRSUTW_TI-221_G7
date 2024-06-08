using System;
using System.Web.Mvc;
using System.Web.Security;
using Calatorii.BusinessLogic;
using Calatorii.BusinessLogic.Interfaces;
using Calatorii.Domain.Entities.User;
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
        public ActionResult Register(UserRegister register, string Role)
        {
            if (ModelState.IsValid)
            {
                URegisterData data = new URegisterData
                {
                    Credential = register.Credential,
                    Password = register.Password,
                    Email = register.Email,
                    RegisterIp = Request.UserHostAddress,
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
