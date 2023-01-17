using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore
{
    internal class LowBudgetPCBuilder : PCBuilder
    {
        public LowBudgetPCBuilder(bool optimizePerformance) : base(optimizePerformance)
        {

        }
        public override void AddCase()
        {
            if (optimizePerformance)
            {
                @case = new ComputerCase("Huawei Basic Silent 3", "Huawei", "Mini PC");
            }
            else
            {
                @case = new ComputerCase("Slim Desktop S01-aF0101ng Jet Black", "HP", "Slim Desktop");
            }
        }

        public override void AddCPU()
        {
            if (optimizePerformance)
            {
                cpu = new CPU("Ryzen 5 4600G 4,2 GHz", "AMD", cores: 6);
            }
            else
            {
                cpu = new CPU("Athlon Gold 3150U, 2C/4T, 2.40-3.30GHz", "AMD", cores: 2);
            }
        }

        public override void AddDisks()
        {
            if (optimizePerformance)
            {
                disks.Add(new Harddisk("SSD 256 GB", "Noname", ssd: true));
            }
            else
            {
                disks.Add(new Harddisk("SSD 256 GB", "Toshiba", ssd: true));
            }
        }

        public override void AddGraphicsCard()
        {
            if (optimizePerformance)
            {
                graphicsCard = new GraphicsCard("Radeon Graphics", "AMD", integrated: true);
            }
            else
            {
                graphicsCard = new GraphicsCard("Radeon Graphics (iGPU)", "AMD", integrated: true);
            }
        }

        public override void AddRAM()
        {
            if (optimizePerformance)
            {
                ram = new MainMemory("8GB DDR4", "Noname");
            }
            else
            {
                ram = new MainMemory("8GB DDR4", "Noname");
            }
        }

        public override void SetPrice()
        {
            if (optimizePerformance)
            {
                price = 578m;
            }
            else
            {
                price = 301.51m;
            }
        }
    }
}
