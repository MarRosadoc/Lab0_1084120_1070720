using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab0_1084120_1070720.Models
{
    public class Client
    {
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [StringLength(8, ErrorMessage = "Please, use Phone Number Format", MinimumLength = 8)]
        public int? Phone { get; set; }
        [Required] 
        public string Description { get; set; }
    }
}
