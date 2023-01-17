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

        public override PCBuilder AddCase()
        {
            throw new NotImplementedException();
        }

        public override PCBuilder AddCPU()
        {
            throw new NotImplementedException();
        }

        public override PCBuilder AddDisks()
        {
            throw new NotImplementedException();
        }

        public override PCBuilder AddGraphicsCard()
        {
            throw new NotImplementedException();
        }

        public override PCBuilder AddRAM()
        {
            throw new NotImplementedException();
        }

        public override PCBuilder SetPrice()
        {
            throw new NotImplementedException();
        }
    }
}
