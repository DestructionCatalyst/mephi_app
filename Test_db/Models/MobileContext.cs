//using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Test_db.Models
{
    public class MobileContext : DbContext
    {
        public DbSet<qr> qrs { get; set; }
        public DbSet<news> newss { get; set; }
        public DbSet<remind> reminds { get; set; }
        public DbSet<dot> dots { get; set; }
        public DbSet<Group> groups { get; set; }
        public DbSet<way> ways { get; set; }
        public DbSet<institution> institutions { get; set; }

        public MobileContext(DbContextOptions<MobileContext> options)
            : base(options)
        {
           //Database.EnsureCreated();
        }
    }
}
