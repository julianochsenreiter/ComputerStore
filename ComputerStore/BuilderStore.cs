using System;

namespace ComputerStore
{
    public class BuilderStore : ComputerStore
    {
        // Typically you will find many more methods here since a computer store
        // has many other things it can do!

        public override PC BuildPC(int budgetChoice, bool optimizePerformance)
        {
            return PCBuilderFactory.CreateBuilder(budgetChoice, optimizePerformance)
                .AddCase()
                .AddCPU()
                .AddRAM()
                .AddDisks()
                .AddGraphicsCard()
                .SetPrice()
                .Build();
        }
    }
}
