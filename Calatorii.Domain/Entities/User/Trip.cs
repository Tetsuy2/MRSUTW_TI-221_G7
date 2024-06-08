using System;

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
