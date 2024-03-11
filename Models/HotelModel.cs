using System.Collections.Generic;

namespace BookingApp.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string ContactDetails { get; set; }

        // Navigation property for rooms
        public ICollection<Room> Rooms { get; set; }
    }
}
