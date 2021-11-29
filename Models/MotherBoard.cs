using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_project.Models
{
    public class MotherBoard
    {
        public int MotherBoardId { get; set; }
        [Requried]
        public string MotherBoardName { get; set; }
        [Requried]
        public double MotherBoardPrice { get; set; }
        [Requried]
        public string ImageLink { get; set; }
    }
}
