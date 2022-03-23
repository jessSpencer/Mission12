using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class Booking //information about the group
    {
        [Key]
        [Required]
        public int BookID {get; set;}
        
        [Required]
        public int AptID { get; set; }
        public Appointment Appointment { get; set; }
        
        [Required(ErrorMessage = "Please enter an Name")]
        public string GroupName { get; set; }
        
        [Required(ErrorMessage = "Please enter a group size")]
        public int GroupSize { get; set; }
        
        [Required(ErrorMessage = "Please enter your email")]
        public string Email { get; set; }
        
        [Phone]
        public int Phone { get; set; }


    }
}

