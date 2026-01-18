using Microsoft.EntityFrameworkCore;
using PayTrack.Models;

namespace PayTrack.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Payment> Payments { get; set; }
    }
}
