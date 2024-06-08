using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Calatorii.Domain.Entities;

namespace Calatorii.Web.Controllers
{
    public class TripController : Controller
    {
        private static List<Trip> trips = new List<Trip>
        {
            new Trip { Id = 1, Name = "Trip to Chișinău", Destination = "Chișinău", Date = new DateTime(2024, 9, 15), Source = "pandatur" },
            new Trip { Id = 2, Name = "Trip to Tiraspol", Destination = "Tiraspol", Date = new DateTime(2024, 10, 20), Source = "pandatur" },
            new Trip { Id = 3, Name = "Trip to Bălți", Destination = "Bălți", Date = new DateTime(2024, 11, 25), Source = "pandatur" },
            new Trip { Id = 4, Name = "Trip to Comrat", Destination = "Comrat", Date = new DateTime(2024, 12, 30), Source = "pandatur" },
            new Trip { Id = 5, Name = "Trip to Cahul", Destination = "Cahul", Date = new DateTime(2024, 1, 15), Source = "admiral" },
            new Trip { Id = 6, Name = "Trip to Orhei", Destination = "Orhei", Date = new DateTime(2024, 2, 20), Source = "admiral" },
            new Trip { Id = 7, Name = "Trip to Soroca", Destination = "Soroca", Date = new DateTime(2024, 3, 25), Source = "pandatur" },
            new Trip { Id = 8, Name = "Trip to Hîncești", Destination = "Hîncești", Date = new DateTime(2024, 4, 15), Source = "pandatur" },
            new Trip { Id = 9, Name = "Trip to Ungheni", Destination = "Ungheni", Date = new DateTime(2024, 5, 20), Source = "admiral" },
            new Trip { Id = 10, Name = "Trip to Călărași", Destination = "Călărași", Date = new DateTime(2024, 6, 25), Source = "pandatur" },
            new Trip { Id = 11, Name = "Trip to Edineț", Destination = "Edineț", Date = new DateTime(2024, 7, 30), Source = "admiral" },
            new Trip { Id = 12, Name = "Trip to Nisporeni", Destination = "Nisporeni", Date = new DateTime(2024, 8, 15), Source = "pandatur" }
        };

        public ActionResult Index(string searchString, string sortBy)
        {
            var filteredTrips = trips.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                filteredTrips = filteredTrips.Where(t => t.Name.Contains(searchString) || t.Destination.Contains(searchString));
            }

            switch (sortBy)
            {
                case "Location":
                    filteredTrips = filteredTrips.OrderBy(t => t.Destination);
                    break;
                case "Date":
                    filteredTrips = filteredTrips.OrderBy(t => t.Date);
                    break;
                case "Source":
                    filteredTrips = filteredTrips.OrderBy(t => t.Source);
                    break;
                default:
                    filteredTrips = filteredTrips.OrderBy(t => t.Id);
                    break;
            }

            return View(filteredTrips.ToList());
        }
    }
}
