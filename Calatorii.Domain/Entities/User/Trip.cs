using System;
<<<<<<< HEAD

namespace Calatorii.Domain.Entities
{
    public class Trip
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Destination { get; set; }
        public DateTime Date { get; set; }
        public string Source { get; set; } // Add this field to track the source website
    }
}
=======
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Calatorii.Domain.Entities.User
{
    public class Trip
    {
        public int Id { get; set; } 
        [MaxLength(100)]
        public string Title { get; set; } = "";
        [MaxLength(100)]
        public string Description { get; set; } = "";
        public decimal Price { get; set; }
        [MaxLength(100)]
        public string ImageFileName { get; set; } = "";
        public DateTime CreatedAt { get; set; }
    }
}
>>>>>>> c07de0dcb2c15f00cd2a80f79ac72649b834707e
