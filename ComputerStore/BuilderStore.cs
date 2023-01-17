using System;

namespace ComputerStore
{
    internal class BuilderStore : ComputerStore
    {
        // Typically you will find many more methods here since a computer store
        // has many other things it can do!

        protected override PC BuildPC(int budgetChoice, bool optimizePerformance)
        {
            PCBuilder builder = PCBuilderFactory.CreateBuilder(budgetChoice, optimizePerformance);

            builder.AddCase();
            builder.AddCPU();
            builder.AddRAM();
            builder.AddDisks();
            builder.AddGraphicsCard();
            builder.SetPrice();
            return builder.Build();
        }
    }
}
