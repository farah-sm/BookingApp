using Microsoft.EntityFrameworkCore;

namespace BookingApp.Models
{
    public class BookingContext : DbContext
    {
        public BookingContext(DbContextOptions<BookingContext> options) : base(options)
        {
        }

        // DbSet properties represent database tables
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     // Configure relationships between entities if needed

        //     // // One-to-Many relationship between Hotel and Room
        //     // modelBuilder.Entity<Room>()
        //     //     .HasOne(room => room.Hotel)
        //     //     .WithMany(hotel => hotel.Rooms)
        //     //     .HasForeignKey(room => room.HotelId);

        //     // // One-to-Many relationship between Hotel and Review
        //     // modelBuilder.Entity<Review>()
        //     //     .HasOne(review => review.Hotel)
        //     //     .WithMany(hotel => hotel.Reviews)
        //     //     .HasForeignKey(review => review.HotelId);

        //     // // One-to-Many relationship between Guest and Booking
        //     // modelBuilder.Entity<Booking>()
        //     //     .HasOne(booking => booking.Guest)
        //     //     .WithMany(guest => guest.Bookings)
        //     //     .HasForeignKey(booking => booking.GuestId);

        //     // // One-to-Many relationship between Hotel and Booking
        //     // modelBuilder.Entity<Booking>()
        //     //     .HasOne(booking => booking.Hotel)
        //     //     .WithMany(hotel => hotel.Bookings)
        //     //     .HasForeignKey(booking => booking.HotelId);

        //     // // One-to-Many relationship between Room and Booking
        //     // modelBuilder.Entity<Booking>()
        //     //     .HasOne(booking => booking.Room)
        //     //     .WithMany(room => room.Bookings)
        //     //     .HasForeignKey(booking => booking.RoomId);
        // }
    }
}
