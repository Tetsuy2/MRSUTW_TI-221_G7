using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calatorii.Web.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}