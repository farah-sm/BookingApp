using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookingApp.Models
{
    public class BookingContext : IdentityDbContext<IdentityUser>
    {
        public BookingContext(DbContextOptions<BookingContext> options) : base(options)
        {
        }

        // DbSet properties represent database tables
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Guest> Guests { get; set; }
        // public DbSet<Review> Reviews { get; set; }
        public DbSet<Booking> Bookings { get; set; }

    }
}
