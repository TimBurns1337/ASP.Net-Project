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
        [Requried]
        public double CpuPrice { get; set; }
        [Required]
        public string Gpu { get; set; } // Cezmi //CpuId
        [Requried]
        public double GpuPrice { get; set; }
        [Required]
        public string MotherBoard { get; set; } //Cezmi
        [Requried]
        public double MotherBoardPrice { get; set; }
        [Required]
        public string Ram { get; set; }//Tim
        [Requried]
        public double RamPrice { get; set; }
        [Required]
        public string Hdd { get; set; }//Tim
        [Requried]
        public double HddPrice { get; set; }
        [Required]
        public string Power { get; set; }//Tim
        [Requried]
        public double PowerPrice { get; set; }
        [Required]
        public string Cooling { get; set; } //Istikbal
        [Required]
        public double CoolingPrice { get; set; }
        [Required]
        public string Case { get; set; } //Istikbal
        [Required]
        public double CasePrice { get; set; }

        // *** Created data folder for context and dbinitial ***
    }
}
