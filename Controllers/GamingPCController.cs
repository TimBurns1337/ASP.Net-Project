using ASP.Net_project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_project.Controllers
{
    public class GamingPCController : Controller
    {
        IList<GamingPC> gamingPCs = new List<GamingPC>
        { new GamingPC()
        { Pc_Id = 1, Componets = "High Performance Gaming PC " +
                                    "CPU: AMD Ryzen 9 5950X $800" +
                                    "GPU: Nvidia GeForce RTX 3090 $1500" +
                                    "Motherboard: Asus ROG Maximus XII Extreme $1000" +
                                    "RAM: TEAM XTREEM ARGB 16GB DDR4-3600MHz C14 $500" +
                                    "Hard Drive: Addlink S70 SSD 2TB $150" +
                                    "Power: Corsair AX1600i 1600W $1000" +
                                    "Cooling: Corsair H115i RGB Platinum $200"+
                                    "Case: PC-O11D Razer Mid Tower $250" +
            "Final Price $4000",
            Summary = "CPU: AMD Ryzen 9 5950X $800 GPU: Nvidia GeForce RTX 3090 $1500, Final Price: $4000",
            Image_Link = "RGB.jpeg", 
            Price = 4000
        },
        new GamingPC()
        { Pc_Id = 2, Componets = "3.7 GHz AMD Ryzen 5 4600G processor and 12GB DDR4 RAM deliver superior speed and power to handle high-end games and editing software",
            Summary = "ASUS ROG Strix G10DK Gaming PC - Grey (AMD Ryzen 5 4600G/512GB SSD/12GB RAM/GTX1660 SUPER)",
            Image_Link = "HP.jpeg",
            Price = 3000
        }};

        public IActionResult Index()
        {
            ViewBag.Action = "Index";
            return View(gamingPCs);
        }

    }
}
