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
        public DbSet<Booking> Booking { get; set; }
        public DbSet<Appointment> Appointment { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Appointment>().HasData(

                //Monday Seeding Appointment Slots
                new Appointment
                {
                    AptId = 1,
                    Time = "8:00 AM",
                    Day = "Monday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 2,
                    Time = "9:00 AM",
                    Day = "Monday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 3,
                    Time = "10:00 AM",
                    Day = "Monday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 4,
                    Time = "11:00 AM",
                    Day = "Monday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 5,
                    Time = "12:00 PM",
                    Day = "Monday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 6,
                    Time = "1:00 PM",
                    Day = "Monday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 7,
                    Time = "2:00 PM",
                    Day = "Monday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 8,
                    Time = "2:00 PM",
                    Day = "Monday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 9,
                    Time = "3:00 PM",
                    Day = "Monday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 10,
                    Time = "4:00 PM",
                    Day = "Monday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 11,
                    Time = "5:00 PM",
                    Day = "Monday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 12,
                    Time = "6:00 PM",
                    Day = "Monday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 13,
                    Time = "7:00 PM",
                    Day = "Monday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 14,
                    Time = "8:00 PM",
                    Day = "Monday",
                    Booked = false,
                },

                //Tuesday Seeding Appointment Slots
                new Appointment
                {
                    AptId = 15,
                    Time = "8:00 AM",
                    Day = "Tuesday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 16,
                    Time = "9:00 AM",
                    Day = "Tuesday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 17,
                    Time = "10:00 AM",
                    Day = "Tuesday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 18,
                    Time = "11:00 AM",
                    Day = "Tuesday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 19,
                    Time = "12:00 PM",
                    Day = "Tuesday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 20,
                    Time = "1:00 PM",
                    Day = "Tuesday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 21,
                    Time = "2:00 PM",
                    Day = "Tuesday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 22,
                    Time = "2:00 PM",
                    Day = "Tuesday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 23,
                    Time = "3:00 PM",
                    Day = "Tuesday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 24,
                    Time = "4:00 PM",
                    Day = "Tuesday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 25,
                    Time = "5:00 PM",
                    Day = "Tuesday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 26,
                    Time = "6:00 PM",
                    Day = "Tuesday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 27,
                    Time = "7:00 PM",
                    Day = "Tuesday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 28,
                    Time = "8:00 PM",
                    Day = "Tuesday",
                    Booked = false,
                },

                //Wednesday Seeding Appointment Slots
                new Appointment
                {
                    AptId = 29,
                    Time = "8:00 AM",
                    Day = "Wednesday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 30,
                    Time = "9:00 AM",
                    Day = "Wednesday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 31,
                    Time = "10:00 AM",
                    Day = "Wednesday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 32,
                    Time = "11:00 AM",
                    Day = "Wednesday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 33,
                    Time = "12:00 PM",
                    Day = "Wednesday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 34,
                    Time = "1:00 PM",
                    Day = "Wednesday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 35,
                    Time = "2:00 PM",
                    Day = "Wednesday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 36,
                    Time = "2:00 PM",
                    Day = "Wednesday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 37,
                    Time = "3:00 PM",
                    Day = "Wednesday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 38,
                    Time = "4:00 PM",
                    Day = "Wednesday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 39,
                    Time = "5:00 PM",
                    Day = "Wednesday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 40,
                    Time = "6:00 PM",
                    Day = "Wednesday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 41,
                    Time = "7:00 PM",
                    Day = "Wednesday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 42,
                    Time = "8:00 PM",
                    Day = "Wednesday",
                    Booked = false,
                },

                //Thursday Seeding Appointment Slots
                new Appointment
                {
                    AptId = 43,
                    Time = "8:00 AM",
                    Day = "Thursday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 44,
                    Time = "9:00 AM",
                    Day = "Thursday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 45,
                    Time = "10:00 AM",
                    Day = "Thursday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 46,
                    Time = "11:00 AM",
                    Day = "Thursday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 47,
                    Time = "12:00 PM",
                    Day = "Thursday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 48,
                    Time = "1:00 PM",
                    Day = "Thursday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 49,
                    Time = "2:00 PM",
                    Day = "Thursday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 50,
                    Time = "2:00 PM",
                    Day = "Thursday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 51,
                    Time = "3:00 PM",
                    Day = "Thursday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 52,
                    Time = "4:00 PM",
                    Day = "Thursday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 53,
                    Time = "5:00 PM",
                    Day = "Thursday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 54,
                    Time = "6:00 PM",
                    Day = "Thursday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 55,
                    Time = "7:00 PM",
                    Day = "Thursday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 56,
                    Time = "8:00 PM",
                    Day = "Thursday",
                    Booked = false,
                },

                //Friday Seeding Appointment Slots
                new Appointment
                {
                    AptId = 57,
                    Time = "8:00 AM",
                    Day = "Friday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 58,
                    Time = "9:00 AM",
                    Day = "Friday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 59,
                    Time = "10:00 AM",
                    Day = "Friday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 60,
                    Time = "11:00 AM",
                    Day = "Friday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 61,
                    Time = "12:00 PM",
                    Day = "Friday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 62,
                    Time = "1:00 PM",
                    Day = "Friday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 63,
                    Time = "2:00 PM",
                    Day = "Friday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 64,
                    Time = "2:00 PM",
                    Day = "Friday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 65,
                    Time = "3:00 PM",
                    Day = "Friday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 66,
                    Time = "4:00 PM",
                    Day = "Friday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 67,
                    Time = "5:00 PM",
                    Day = "Friday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 68,
                    Time = "6:00 PM",
                    Day = "Friday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 69,
                    Time = "7:00 PM",
                    Day = "Friday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 70,
                    Time = "8:00 PM",
                    Day = "Friday",
                    Booked = false,
                },

                //Saturday Seeding Appointment Slots
                new Appointment
                {
                    AptId = 71,
                    Time = "8:00 AM",
                    Day = "Saturday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 72,
                    Time = "9:00 AM",
                    Day = "Saturday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 73,
                    Time = "10:00 AM",
                    Day = "Saturday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 74,
                    Time = "11:00 AM",
                    Day = "Saturday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 75,
                    Time = "12:00 PM",
                    Day = "Saturday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 76,
                    Time = "1:00 PM",
                    Day = "Saturday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 77,
                    Time = "2:00 PM",
                    Day = "Saturday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 78,
                    Time = "2:00 PM",
                    Day = "Saturday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 79,
                    Time = "3:00 PM",
                    Day = "Saturday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 80,
                    Time = "4:00 PM",
                    Day = "Saturday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 81,
                    Time = "5:00 PM",
                    Day = "Saturday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 82,
                    Time = "6:00 PM",
                    Day = "Saturday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 83,
                    Time = "7:00 PM",
                    Day = "Saturday",
                    Booked = false,
                },
                new Appointment
                {
                    AptId = 84,
                    Time = "8:00 PM",
                    Day = "Saturday",
                    Booked = false,
                }
                );

        }
    }
}
