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
        [Key]
        [Required]
        public int AppointmentID { get; set; }

        public string GroupName { get; set; }
        [Required(ErrorMessage = "Please enter an Author")]
        public int GroupSize { get; set; }

        public string Email { get; set; }

        public int Phone { get; set; }


    }
}

