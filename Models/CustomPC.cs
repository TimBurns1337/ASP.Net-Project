using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_project.Models
{
    public class CustomPC
    {
        public int CustomPcId { get; set; }
        [Required]
        public string Cpu { get; set; }
        [Required]
        public string Gpu { get; set; }
        [Required]
        public string MotherBoard { get; set; }
        [Required]
        public string Ram { get; set; }
        [Required]
        public string Hdd { get; set; }
        [Required]
        public string Power { get; set; }
        [Required]
        public string Cooling { get; set; }
        [Required]
        public string Case { get; set; }
    }
}
