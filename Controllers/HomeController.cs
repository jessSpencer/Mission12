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
        private AptContext aptContext { get; set; }


        public HomeController(AptContext x)
        {
            aptContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Bookings()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }
        public IActionResult Signup()
        {
            var appointments = aptContext.appointments
                .Where(x => x.Booked == false)
                .ToList();
            return View(appointments);
        }

    }
}
