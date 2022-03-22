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
        //public DbSet<Booking> booking { get; set; }
        public DbSet<Appointment> appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Appointment>().HasData(
                new Appointment
                {
                    AptId = 1,
                    Time = "",
                    Day = "",
                },
                new Appointment
                {
                }
            );

        }
    }
}
