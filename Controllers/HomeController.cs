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
        public IActionResult Form(int AptId)
        {
            ViewBag.Apt = AptContext.Appointment.FirstOrDefault(x => x.AptId == AptId);

            return View(new Booking());
        }

        [HttpPost]
        public IActionResult Form(Booking booking) //idk what to put here to make the date and time get sent from signup to form view?
        {


            if (ModelState.IsValid)
            {
               
                AptContext.Add(booking);
                AptContext.Appointment.FirstOrDefault(x => (x.Day == booking.Day && x.Time == booking.Time)).Booked = true;
                AptContext.SaveChanges();

                return RedirectToAction("Bookings");
            }
            else
            {
                ViewBag.Apt = AptContext.Booking.FirstOrDefault(x => x.BookID == booking.BookID);
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

            ViewBag.Apt = AptContext.Booking.FirstOrDefault(x => x.BookID == booking.BookID);
            return View("Edit", booking);
        }

        [HttpPost]
        public IActionResult Edit(Booking booking)
        {
            AptContext.Update(booking);
            
            AptContext.SaveChanges();

            return RedirectToAction("Bookings");

        }


        //[HttpGet]
        //public IActionResult Delete (int bookid)
        //{
        //    var booking = AptContext.Booking.Single(x => x.BookID == bookid);
        //    return View("Bookings");
        //}
        
        [HttpPost]
        public IActionResult Delete (Booking b)
        {
            
            AptContext.Booking.Remove(b);
            AptContext.SaveChanges();
            return RedirectToAction("Bookings");
        }

  

    }
}
