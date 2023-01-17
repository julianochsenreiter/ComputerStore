using System;
using ComputerStore;

public class Program
{
    public static void Main(string[] args)
    {
        var store = new BuilderStore();
        try
        {
            PC pc = store.BuyPC();
            Console.WriteLine($"Your new PC costs {pc.Price} Euro.");
            Console.WriteLine("The components of your PC:");
            Console.WriteLine("--------------------------");
            Console.WriteLine(pc);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error building PC: {ex.Message}.");
        }
    }
}
