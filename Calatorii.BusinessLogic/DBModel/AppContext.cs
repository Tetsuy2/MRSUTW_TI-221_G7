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
<<<<<<< HEAD

=======
        public AppContext() : base("name=CalatoriiConnectionString")
        {
        }
        public DbSet<Trip> Trips { get; set; }
>>>>>>> c07de0dcb2c15f00cd2a80f79ac72649b834707e
    }

}
