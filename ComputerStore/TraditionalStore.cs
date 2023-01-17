//using System;

//namespace ComputerStore
//{
//    internal class TraditionalStore : ComputerStore
//    {
//        // Typically you will find many more methods here since a computer store
//        // has many other things it can do!

//        protected override PC BuildPC(int budgetChoice, bool optimizePerformance)
//        {
//            if (budgetChoice == 1)
//            {
//                throw new InvalidOperationException("Cannot build a PC for so little money.");
//            }
//            else if (budgetChoice == 2)
//            {
//                if (optimizePerformance)
//                {
//                    //return new PC(@case, cpu, ram, new Harddisk[] { harddisk }, graphics, 578m);
//                }
//                else
//                {
//                    var graphics = new GraphicsCard("Radeon Graphics (iGPU)", "AMD", integrated: true);
//                    //return new PC(@case, cpu, ram, new Harddisk[] { harddisk }, graphics, 301.51m);
//                }
//            }
//            else if (budgetChoice == 3)
//            {
//                if (optimizePerformance)
//                {
//                    var @case = new ComputerCase("Acer Predator Orion 3000", "Acer", "Midi Tower");
//                    var cpu = new CPU("Core i5-11400F", "Intel", cores: 6);
//                    var ram = new MainMemory("16GB DDR4-3200 (2x 8GB Module, 4 Slots, max. 64GB)", "Noname");
//                    var harddisk1 = new Harddisk("256GB M.2 PCIe (2280)", "Corsair", ssd: true);
//                    var harddisk2 = new Harddisk("1TB HDD", "Seagate", ssd: false);
//                    var graphics = new GraphicsCard("GeForce GTX 1660 SUPER - 6GB GDDR6 - Desktop", "Nvidia", integrated: false);
//                    return new PC(@case, cpu, ram, new Harddisk[] { harddisk1, harddisk2 }, graphics, 999m);
//                }
//                else
//                {
//                    var @case = new ComputerCase("Terra PC-Business 5000", "Wortmann", "Midi Tower");
//                    var cpu = new CPU("Core i5-10400", "Intel", cores: 6);
//                    var ram = new MainMemory("8GB RAM", "Noname");
//                    var harddisk1 = new Harddisk("256GB M.2 PCIe (2280)", "Corsair", ssd: true);
//                    var harddisk2 = new Harddisk("512GB HDD", "Seagate", ssd: false);
//                    var graphics = new GraphicsCard("UHD Graphics 630 (iGPU)", "Intel", integrated: true);
//                    return new PC(@case, cpu, ram, new Harddisk[] { harddisk1, harddisk2 }, graphics, 602.03m);
//                }
//            }
//            else
//            {
//                if (optimizePerformance)
//                {
//                    var @case = new ComputerCase("Captiva Highend Gaming R60-386", "Captiva", "Tower");
//                    var cpu = new CPU("Ryzen 9 5900X", "AMD", cores: 12);
//                    var ram = new MainMemory("16GB DDR4-3000 (2x 8GB Module, 2 Slots, max. 128GB)", "Samsung");
//                    var harddisk1 = new Harddisk("1TB M.2 PCIe", "Samsung", ssd: true);
//                    var harddisk2 = new Harddisk("1TB HDD", "Western Digital", ssd: false);
//                    var graphics = new GraphicsCard("GeForce RTX 3060 - 12GB GDDR6 - Desktop", "Nvidia", integrated: false);
//                    return new PC(@case, cpu, ram, new Harddisk[] { harddisk1, harddisk2 }, graphics, 1999m);
//                }
//                else
//                {
//                    var @case = new ComputerCase("ThinkStation P350 Tiny", "Lenovo", "Tiny 89%");
//                    var cpu = new CPU("Core i5-11600, 2.80-4.80GHz", "Intel", cores: 6);
//                    var ram = new MainMemory("16GB DDR4-3200 SO-DIMM", "Kingston");
//                    var harddisk = new Harddisk("512GB M.2 PCIe 4.0 (2280)", "Samsung", ssd: true);
//                    var graphics = new GraphicsCard("UHD Graphics 750 (iGPU)", "Intel", integrated: true);
//                    return new PC(@case, cpu, ram, new Harddisk[] { harddisk }, graphics, 1999m);
//                }
//            }
//        }
//    }
//}
