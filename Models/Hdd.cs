using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_project.Models
{
    public class Hdd
    {
        public int HddId { get; set; }
        [Requried]
        public string HddName { get; set; }
        [Requried]
        public double HddPrice { get; set; }
        [Requried]
        public string ImageLink { get; set; }

        // may want to add image link and brnad name in further migrations 
    }
}
