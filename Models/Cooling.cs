using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_project.Models
{
    public class Cooling
    {
        public int CoolingId { get; set; }
        [Requried]
        public string CoolingName { get; set; }
        [Requried]
        public double CoolingPrice { get; set; }
        [Requried]
        public string ImageLink { get; set; }
    }
}
