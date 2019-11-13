using Microsoft.EntityFrameworkCore;

namespace Test_db.Models
{
    public class MobileContext : DbContext
    {
        public DbSet<qr> qrs { get; set; }
        public DbSet<news> newss { get; set; }
        public DbSet<remind> reminds { get; set; }

        public MobileContext(DbContextOptions<MobileContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
