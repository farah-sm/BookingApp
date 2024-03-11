using System.Collections.Generic;

namespace BookingApp.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int GuestId { get; set; }  // Foreign key to Guest
        public Guest Guest { get; set; }  // Navigation property to Guest
        public int HotelId { get; set; }  // Foreign key to Hotel
        public Hotel Hotel { get; set; }  // Navigation property to Hotel
        public int RoomId { get; set; }   // Foreign key to Room
        public Room Room { get; set; }    // Navigation property to Room
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
