using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab0_CésarSilva_1184519__JonnathanLanuza_1082219.Models
{
    public class Clients
    {
        [Required]
        public string Name { get; set; }
        public string Lastname { get; set; }
        [Display(Name = "Phone Number")]
        public int? PhoneNumber { get; set; }
        public string Description { get; set; }
    }
}
