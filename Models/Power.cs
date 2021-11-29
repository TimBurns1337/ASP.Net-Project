using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_project.Models
{
    public class Power
    {
        public int PowerId { get; set; }
        [Requried]
        public string PowerName { get; set; }
        [Requried]
        public double PowerPrice { get; set; }
        [Requried]
        public string ImageLink { get; set; }

        // may want to add image link and brnad name in further migrations 
    }
}
