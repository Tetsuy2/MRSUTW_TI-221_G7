using System.Web.Mvc;

namespace Calatorii.Web.Controllers
{
    public class TravelController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Monuments()
        {
            return View("~/Views/Monuments/Monuments.cshtml");
        }

        public ActionResult Wineries()
        {
            return View("~/Views/Wineries/Wineries.cshtml");
        }

        public ActionResult Parks()
        {
            return View("~/Views/Parks/Parks.cshtml");
        }

        public ActionResult Culture()
        {
            return View("~/Views/Culture/Culture.cshtml");
        }

        public ActionResult Church()
        {
            return View("~/Views/Church/Church.cshtml");
        }
    }
}
