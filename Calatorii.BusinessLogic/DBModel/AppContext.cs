using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calatorii.Domain.Entities.User;

namespace Calatorii.BusinessLogic.DBModel
{
    public class AppContext : DbContext
    {
        public AppContext() : base("name=CalatoriiConnectionString")
        {
        }
        public DbSet<Trip> Trips { get; set; }
    }

}
