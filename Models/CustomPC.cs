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
        public string Cpu { get; set; } //Cezmi  //CpuId CpuName CpuPrice
        [Required]
        public string Gpu { get; set; } // Cezmi //CpuId
        [Required]
        public string MotherBoard { get; set; } //Cezmi
        [Required]
        public string Ram { get; set; }//Tim
        [Required]
        public string Hdd { get; set; }//Tim
        [Required]
        public string Power { get; set; }//Tim
        [Required]
        public string Cooling { get; set; } //Istikbal
        [Required]
        public string Case { get; set; } //Istikbal


    }
}
