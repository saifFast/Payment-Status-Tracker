using Microsoft.EntityFrameworkCore;
using PayTrack.Models;

namespace PayTrack.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Payment> Payments { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
