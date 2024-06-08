using System.Web.Mvc;
using System.Web.Security;

namespace Calatorii.Web.Controllers
{
    public class LogOutController : Controller
    {
        public ActionResult Index()
        {
            FormsAuthentication.SignOut();
            return View();
        }
    }
}
