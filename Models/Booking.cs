using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class Booking
    {
        [Key]
        [Required]
        public int BookID { get; set; }
        [Required]
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public int GroupSize { get; set; }

    }
}
