using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore
{
    internal class UnlimitedBudgetPCBuilder : PCBuilder
    {
        public UnlimitedBudgetPCBuilder(bool optimizePerformance) : base(optimizePerformance)
        {
        }

        public override void AddCase()
        {
            throw new NotImplementedException();
        }

        public override void AddCPU()
        {
            throw new NotImplementedException();
        }

        public override void AddDisks()
        {
            throw new NotImplementedException();
        }

        public override void AddGraphicsCard()
        {
            throw new NotImplementedException();
        }

        public override void AddRAM()
        {
            throw new NotImplementedException();
        }

        public override void SetPrice()
        {
            throw new NotImplementedException();
        }
    }
}
