using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class Appointment //these are the appointment times
    {
        [Key]
        [Required]
        public int AptId { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public string Day { get; set; }

        public bool Booked { get; set; }

    }
}
