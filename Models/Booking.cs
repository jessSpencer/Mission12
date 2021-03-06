using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class Booking //information about the group
    {
        [Key]
        [Required]
        public int BookID {get; set;}
        

        
        [Required(ErrorMessage = "Please enter an Name")]
        public string GroupName { get; set; }
        
        [Required(ErrorMessage = "Please enter a group size")]
        [Range(0,15,ErrorMessage = "Groups can have a maximum of 15 individuals")]
        public int GroupSize { get; set; }
        
        [Required(ErrorMessage = "Please enter your email")]
        public string Email { get; set; }
        
        public string Phone { get; set; }

        public string Time { get; set; }

        public string Day { get; set; }

        //[ForeignKey ("Appointment")]
        //public int AptId { get; set; }
        //public Appointment Appointment { get; set; }


    }
}

