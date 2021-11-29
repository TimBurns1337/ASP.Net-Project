using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_project.Models
{
    public class Cpu
    {
        public int CpuId { get; set; }
        [Requried]
        public string CpuName { get; set; }
        [Requried]
        public double CpuPrice { get; set; }
        [Requried]
        public string ImageLink { get; set; }
    }
}
