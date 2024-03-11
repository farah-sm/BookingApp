
namespace BookingApp.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int HotelId { get; set; }  // Foreign key to Hotel
        public Hotel? Hotel { get; set; }  // Navigation property to Hotel
        public string? RoomNumber { get; set; }
        public string? Type { get; set; }
        public int Capacity { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
    }
}
