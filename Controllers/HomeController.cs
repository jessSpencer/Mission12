using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission12.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Controllers
{
    public class HomeController : Controller
    {
        private AptContext AptContext { get; set; }


        public HomeController(AptContext x)
        {
            AptContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Bookings()
        {
            var bookings = AptContext.Booking
                .ToList();
            return View(bookings);
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Booking book) //idk what to put here to make the date and time get sent from signup to form view?
        {                           // we don't actually have to show the date and time (Henry Cho didn't)
            if (ModelState.IsValid)
            {
                AptContext.Add(book);
                AptContext.SaveChanges();

                return RedirectToAction("Bookings");
            }
            else
            {
                return View(book);
            }

            return View();
        }

        public IActionResult Signup()
        {
            var appointments = AptContext.Appointment
                .Where(x => x.Booked == false)
                .ToList();
            return View(appointments);
        }

    }
}
