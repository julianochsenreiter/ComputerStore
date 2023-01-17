using System;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace ComputerStore
{
    public class PC
    {
        public PC(ComputerCase @case, CPU cpu, MainMemory ram, Harddisk[] disks, GraphicsCard graphicsCard, decimal price)
        {
            Case = @case;
            Processor = cpu;
            RAM = ram;
            Disks = disks;
            GraphicsCard = graphicsCard;
            Price = price;
        }

        public ComputerCase Case { get; }
        public CPU Processor { get; }
        public MainMemory RAM { get; }
        public Harddisk[] Disks { get; }
        public GraphicsCard GraphicsCard { get; }
        public decimal Price { get; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder()
            .AppendLine(Case.ToString())
            .AppendLine(Processor.ToString())
            .AppendLine(RAM.ToString())
            .AppendLine("Disks");

            foreach (var disk in Disks)
            {
                builder.AppendLine("\t" + disk.ToString());
            }

            builder.AppendLine(GraphicsCard.ToString());
            return builder.ToString();
        }
    }
}