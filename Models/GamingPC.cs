using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_project.Models
{
    public class GamingPC
    {
        public int PcId { get; set; }
        // see all the details of the pc 
        public string Componets { get; set; }
        // proived a shorted view of components - cpu and gpu 
        public string Summary { get; set; }
        public string Image_Link { get; set; }
        public int Price { get; set; }

    }
}
