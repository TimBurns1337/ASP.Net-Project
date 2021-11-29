using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_project.Models
{
    public class Ram
    {
        public int RamId { get; set; }
        [Requried]
        public string RamName { get; set; }
        [Requried]
        public double RamPrice { get; set; }
        [Requried]
        public string ImageLink { get; set; }

        // may want to add image link and brnad name in further migrations 
    }
}
