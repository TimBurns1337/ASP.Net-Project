using ASP.Net_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_project.Data
{
    public class DbInitializer
    {
        public static void Initialize(ComputerContext context)
        {
            if (context.GamingPCs.Any())
            {
                return;   // DB has been seeded
            }

            // use below format to add data you want to the database
            var gamingpcs = new GamingPC[]
            {
            new GamingPC{PcId = 1,
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
            Price = 4000},
            new GamingPC{PcId = 2,
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
            Price = 3000},
            new GamingPC{PcId = 3,
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
            Price = 1300}            
            };
            foreach (GamingPC gpc in gamingpcs)
            {
                context.GamingPCs.Add(gpc);
            }
            context.SaveChanges();

            // Ram data
            var rams = new Ram[]
            {
            new Ram{RamId = 1, RamName = "G.SKILL Ripjaws V Series 32GB (2 x 16GB)", RamPrice = 149.99},
            new Ram{RamId = 2, RamName = "G.SKILL Ripjaws V Series 16GB (2 x 8GB)", RamPrice = 89.99},
            new Ram{RamId = 3, RamName = "CORSAIR Vengeance RGB Pro 16GB (2 x 8GB)", RamPrice = 123.99}
            };
            foreach (Ram r in rams)
            {
                context.Rams.Add(r);
            }
            context.SaveChanges();

            // HDD / SSD data
            var hdds = new Hdd[]
            {
            new Hdd{HddId = 1, HddName = "Seagate BarraCuda ST2000DM008 2TB", HddPrice = 89.99},
            new Hdd{HddId = 2, HddName = "WD Blue 3D NAND 1TB Internal SSD", HddPrice = 139.99},
            new Hdd{HddId = 3, HddName = "WD Blue 3D NAND 2TB Internal SSD", HddPrice = 269.99}
            };
            foreach (Hdd h in hdds)
            {
                context.Hdds.Add(h);
            }
            context.SaveChanges();

            // Power data
            var powers = new Power[]
            {
            new Power{PowerId = 1, PowerName = "ASUS ROG STRIX 850G 850W Gold", PowerPrice = 246.99},
            new Power{PowerId = 2, PowerName = "ASUS ROG Strix 750 Fully Modular 80 Plus Gold 750W", PowerPrice = 139.99},
            new Power{PowerId = 3, PowerName = "CORSAIR RMx Series (2021) RM750x", PowerPrice = 169.99}
            };
            foreach (Power p in powers)
            {
                context.Powers.Add(p);
            }
            context.SaveChanges();

            // Cooling data
            var coolings = new Cooling[]
            {
            new Cooling{CoolingId = 1, CoolingName = "NZXT Kraken X53 240mm - RL-KRX53-01 - AIO RGB CPU Liquid Cooler ", CoolingPrice = 113.18},
            new Cooling{CoolingId = 2, CoolingName = "Vetroo V240 Water Cooler r", CoolingPrice = 79.99},
            new Cooling{CoolingId = 3, CoolingName = "Thermaltake Floe Triple Riing RGB 360 TT Premium Edition", CoolingPrice = 199.99}
            };
            foreach (Cooling cl in coolings)
            {
                context.Coolings.Add(cl);
            }
            context.SaveChanges();


            // Case data
            var cases = new Case[]
            {
            new Case{CaseId = 1, CaseName = "MUSETEX 6pcs 120mm ARGB Fans and USB3.0 ATX Mid-Tower Chassis Gaming PC Case", CasePrice = 89.99},
            new Case{CaseId = 2, CaseName = "ATX Mid-Tower PC Gaming Case ", CasePrice = 62.99},
            new Case{CaseId= 3, CaseName = "GIM ATX Mid-Tower Case", CasePrice = 115.99}
            };
            foreach (Case cs in cases)
            {
                context.Cases.Add(cs);
            }
            context.SaveChanges();

            //Cpu Data
            var cpus = new Cpu[]
            {
                new Cpu{CpuId= 1, CpuName="Intel Core i3 10100F", CpuPrice=129.99},
                new Cpu{CpuId= 2, CpuName="AMD Ryzen 5 5600X", CpuPrice=358.99},
                new Cpu{CpuId= 3, CpuName="Intel Core i7 10700K", CpuPrice=418.99}
            };
            foreach(Cpu cpu in cpus)
            {
                context.Cpus.Add(cpu);
            }
            context.SaveChanges();

            //Gpu Data
            var gpus = new Gpu[]
            {
                new Gpu{GpuId=1, GpuName="AMD FirePro W9000", GpuPrice=350.99},
                new Gpu{GpuId=2, GpuName="Gigabyte GeForce GT 1030", GpuPrice=271.70},
                new Gpu{GpuId=3, GpuName="Asus GeForce GTX 1050", GpuPrice=349.46}
            };
            foreach (Gpu gpu in gpus)
            {
                context.Gpus.Add(gpu);
            }
            context.SaveChanges();

            //MotherBoard Data
            var mb = new MotherBoard[]
            {
                new MotherBoard{MotherBoardId=1, MotherBoardName="Asus h170-pro/csm", MotherBoardPrice=361.25},
                new MotherBoard{MotherBoardId=2, MotherBoardName="MSI MAG Z690", MotherBoardPrice=391.25},
                new MotherBoard{MotherBoardId=3, MotherBoardName="Intel DX58SO Extreme", MotherBoardPrice=561.25}
            };
            foreach (MotherBoard mbItem in mb)
            {
                context.MotherBoards.Add(mbItem);
            }
            context.SaveChanges();


        }
    }
}
