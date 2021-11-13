using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_project.Models
{
    public class Ram
    {
        public int RamId { get; set; }
        
        public string RamName { get; set; }
        
        public Double RamPrice { get; set; }    
        
        // may want to add image link and brnad name in further migrations 
    }
}
