using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission12.Models;
using Mission12.Models.ViewModels;
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
        public IActionResult Form(int aptId)
        {
            var x = new BookingViewModel
            {
                Apt = AptContext.Appointment.FirstOrDefault(x => x.AptId == aptId),

                Book = new Booking()
            };

            return View(x);
        }

        [HttpPost]
        public IActionResult Form(BookingViewModel booking) //idk what to put here to make the date and time get sent from signup to form view?
        {                           // we don't actually have to show the date and time (Henry Cho didn't)(But I think we should)
            if (ModelState.IsValid)
            {
                AptContext.Appointment.Single(x => x.AptId == booking.Book.Appointment.AptId).Booked = true;
                AptContext.Add(booking.Book);
                AptContext.SaveChanges();

                return RedirectToAction("Bookings");
            }
            else
            {
                return View(booking);
            }

        }

        public IActionResult Signup()
        {
            var appointments = AptContext.Appointment
                .Where(x => x.Booked == false)
                .ToList();
            return View(appointments);
        }

        [HttpGet]
        public IActionResult Edit(int bookid)
        {
            var booking = AptContext.Booking.Single(x => x.BookID == bookid);
            return View("Form", booking);
        }

        //[HttpPost]


        [HttpGet]
        public IActionResult Delete (int bookid)
        {
            var booking = AptContext.Booking.Single(x => x.BookID == bookid);
            return View("Bookings");
        }
        
        [HttpPost]
        public IActionResult Edit(Booking book)
        {
            AptContext.Update(book);
            AptContext.SaveChanges();

            return RedirectToAction("Bookings");
        }
        public IActionResult Delete (Booking b)
        {
            AptContext.Booking.Remove(b);
            AptContext.SaveChanges();
            return RedirectToAction("Bookings");
        }

    }
}
