using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore
{
    internal static class PCBuilderFactory
    {
        internal static PCBuilder CreateBuilder(int budgetChoice, bool optimizePerformance)
        {
            if (budgetChoice == 1)
            {
                throw new InvalidOperationException("Cannot build a PC for so little money.");
            }
            else if (budgetChoice == 2)
            {
                return new LowBudgetPCBuilder(optimizePerformance);
            }
            else if (budgetChoice == 3)
            {
                return new MediumBudgetPCBuilder(optimizePerformance);
            }
            else
            {
                return new UnlimitedBudgetPCBuilder(optimizePerformance);
            }
        }
    }
}
