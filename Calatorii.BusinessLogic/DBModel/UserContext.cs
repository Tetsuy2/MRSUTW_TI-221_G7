using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calatorii.Domain.Entities.User;

namespace Calatorii.BusinessLogic.DBModel
{
     class UserContext : DbContext
     {
          public UserContext() : 
               base("name = Calatorii")
          {
          }
          public virtual DbSet <UDbTable> Users { get; set; }
     }
}
