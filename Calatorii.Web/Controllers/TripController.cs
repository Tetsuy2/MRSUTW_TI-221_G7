using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calatorii.BusinessLogic.DBModel; // Make sure this using directive is here

namespace Calatorii.Web.Controllers
{
    public class TripController : Controller
    {
        private readonly Calatorii.BusinessLogic.DBModel.AppContext context;

        public TripController(Calatorii.BusinessLogic.DBModel.AppContext context)
        {
            this.context = context;
        }

        public ActionResult Index()
        {
            var trips = context.Trips.ToList();
            return View(trips);
        }
    }
}
