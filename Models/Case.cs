using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_project.Models
{
    public class Case
    {
        public int CaseId { get; set; }
        [Requried]
        public string CaseName { get; set; }
        [Requried]
        public double CasePrice { get; set; }
        [Requried]
        public string ImageLink { get; set; }
    }
}
