using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_project.Models
{
    public class Gpu
    {
        public int GpuId { get; set; }
        [Requried]
        public string GpuName { get; set; }
        [Requried]
        public double GpuPrice { get; set; }
        [Requried]
        public string ImageLink { get; set; }
    }
}
