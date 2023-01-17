using System;

namespace ComputerStore
{
    internal abstract class ComputerStore
    {
        public PC BuyPC()
        {
            Console.WriteLine("Welcome to the 'Crazy Machines' computer store!");
            Console.WriteLine("***********************************************");
            Console.WriteLine();
            Console.WriteLine("What is the budget for your new PC? ");
            Console.WriteLine("  <= 300:  (1)");
            Console.WriteLine("  <= 600:  (2)");
            Console.WriteLine("  <= 1000: (3)");
            Console.WriteLine("   > 1000: (4)");

            int budgetChoice = int.Parse(Console.ReadLine());
            Console.WriteLine("Do you want to optimize for performance within your budget (1) or for price (2)? ");
            int optimization = int.Parse(Console.ReadLine());
            Console.WriteLine();

            return BuildPC(budgetChoice, optimization == 1 ? true : false);
        }

        protected abstract PC BuildPC(int budgetChoice, bool optimizePerformance);
    }
}
