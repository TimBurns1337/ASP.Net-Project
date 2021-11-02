using ASP.Net_project.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_project.Controllers
{

    public class GamingPCController : Controller
    { 
        IList<GamingPC> gamingPCs = new List<GamingPC>        
        { new GamingPC()
        { PcId = 1,
            Componets = "High Performance Gaming PC " +
                                    "CPU: AMD Ryzen 9 5950X $800" +
                                    "GPU: Nvidia GeForce RTX 3090 $1500" +
                                    "Motherboard: Asus ROG Maximus XII Extreme $1000" +
                                    "RAM: TEAM XTREEM ARGB 16GB DDR4-3600MHz C14 $500" +
                                    "Hard Drive: Addlink S70 SSD 2TB $150" +
                                    "Power: Corsair AX1600i 1600W $1000" +
                                    "Cooling: Corsair H115i RGB Platinum $200"+
                                    "Case: PC-O11D Razer Mid Tower $250",
            Summary = "CPU: AMD Ryzen 9 5950X $800 GPU: Nvidia GeForce RTX 3090",
            Name = "RTX 3090 Build",
            ImageLink = "Rog.jfif",
            Price = 4000
        },
        new GamingPC()
        { PcId = 2,
            Componets = "3.7 GHz AMD Ryzen 5 4600G processor and 12GB DDR4 RAM deliver superior speed and power to handle high-end games and editing software" +
                        "512GB M.2 NVMe PCIe 3.0 solid state drive quickly loads programs, while offering enough storage space" +
                        "6GB DDR6 NVIDIA GeForce GTX1660 SUPER dedicated graphics card enhances visuals clarity for an improved gaming and editing experience" +
                        "Wi-Fi 5 (802.11ac) and 10/100/1000 Ethernet port provide high-speed wireless and wired network connectivity for non-stop browsing and streaming" +
                        "Bluetooth 5.0 lets you connect with wireless media devices such as mouse, keyboard, speakers, headset, and more" +
                        "Two USB 3.2 Gen 1 Type-A ports, 4 USB 3.2 Gen 1 Type-A ports, 2 USB 3.2 Gen 2 Type-A ports, 1 RJ45 LAN port, 1 HDMI 1.4 port, 1 VGA Port, 1 DVI-D, 1 PS2, 3 audio jacks, and 1 3.5mm combo audio jack allow flexible wired connectivity" +
                        "High Definition 7.1 channel audio with AMD B550 Chipset sound card boosts sound quality that will immerse you into the action" +
                        "VR ready design supports advanced Virtual Reality software and games" +
                        "Windows 10 Home operating system comes with a robust security system, handy features, and Croatia virtual assistant",
            Summary = "ASUS ROG Strix G10DK Gaming PC - Grey (AMD Ryzen 5 4600G/512GB SSD/12GB RAM/GTX1660 SUPER)",
            Name = "Ryzen 5 Build",
            ImageLink = "RGB.jpg",
            Price = 3000
        },
        new GamingPC()
        {
            PcId = 3,
            Componets = "3.8GHz AMD Ryzen 7-5800X octa-core processor with 16GB DDR4 RAM gives you high octane performance that can handle the toughest games of its era" +
                        "2TB hard disk drive and 512GB PCIe solid state drive provide plenty of storage for your games, media, and other data" +
                        "8GB NVIDIA GeForce RTX3070 graphics card with ray-tracing technology produces astonishing visuals that look as realistic and detailed as ever" +
                        "Wi-Fi 5 (802.11ac) and 10/100/1000 Ethernet port provide high-speed wireless and wired network connectivity for non-stop browsing and streaming" +
                        "Bluetooth 5.0 lets you connect with wireless media devices such as mouse, keyboard, speakers, headset, and more" +
                        "Two USB 3.2 Gen 1 Type-A ports, 4 USB 3.2 Gen 1 Type-A ports, 2 USB 3.2 Gen 2 Type-A ports, 1 RJ45 LAN port, 1 HDMI 1.4 port, 1 VGA Port, 1 DVI-D, 1 PS2, 3 audio jacks, and 1 3.5mm combo audio jack allow flexible wired connectivity" +
                        "High Definition 7.1 channel audio with AMD B550 Chipset sound card boosts sound quality that will immerse you into the action" +
                        "VR ready design supports advanced Virtual Reality software and games" +
                        "Windows 10 Home operating system comes with a robust security system, handy features, and Croatia virtual assistant",
            Summary = "ASUS ROG Strix G15DK Gaming PC - Black (AMD Ryzen 7-5800X/2TB HDD/512GB SSD/16GB RAM/GeForce RTX 3070)",
            Name = "Ryzen 7 Build",
            ImageLink = "g15dk.jpg",
            Price = 1300
        }};

        public IActionResult Index()
        {
            ViewBag.Action = "Index";
            return View(gamingPCs);
        }        

        public IActionResult Details(int id)
        {
            ViewBag.Action = "Details";
            return View(gamingPCs[id - 1]);
        }

        public GamingPC Purchase2(int id)
        {
            return gamingPCs.FirstOrDefault(gpc => gpc.PcId == id);            
        }
        public IActionResult Purchase(int id, GamingPC gpc)
        {
            ViewBag.Action = "Purchase";
            ViewBag.PurCompId = id;
            GamingPC GPC = Purchase2(id);
            
            ViewBag.PurCompPrice = GPC.Price;
            //ViewBag.PurCompPrice = Purchase(gpc);
            // test below - can recieve this value but not the above 
            //ViewBag.PurCompPrice = 4000;

            return View();
        }

        

        [HttpPost]
        public IActionResult Confirm(IFormCollection collection)
        {
            try
            {
                ViewData["Fname"] = collection["Fname"];
                ViewData["Lname"] = collection["Lname"];
                ViewData["Price"] = collection["Price"];
                ViewData["Address"] = collection["Address"];
                return View("Confirm");
            }
            catch
            {
                return View();
            }
        }

    }
}
