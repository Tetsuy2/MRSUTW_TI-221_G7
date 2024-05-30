using System;
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