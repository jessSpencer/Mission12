using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models.ViewModels
{
    public class BookingViewModel
    {
        public IQueryable<Appointment> Apt { get; set; }
        public IQueryable<Booking> Book { get; set; }
    }
}
