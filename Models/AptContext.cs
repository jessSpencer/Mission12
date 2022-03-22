using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class AptContext : DbContext
    {

        public AptContext(DbContextOptions<AptContext> options) : base(options)
        {

        }
        public DbSet<Booking> bk { get; set; }
        public DbSet<Appointment> apt { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Appointment>().HasData(
                new Appointment { CategoryId = 1, CategoryName = "Home" },
                new Appointment { CategoryId = 2, CategoryName = "School" },
                new Appointment { CategoryId = 3, CategoryName = "Work" },
                new Appointment { CategoryId = 4, CategoryName = "Church" }
            );
            //seeding the database
            mb.Entity<Booking>().HasData(
                new Booking
                {
                    BookID = 1,
                    Name = "",
                    Email = "",
                    GroupSize = 2,
                    Phone = 0

                },
                new Booking
                {

                }
            );

        }
    }
}
