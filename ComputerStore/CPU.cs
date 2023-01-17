namespace ComputerStore
{
    public class CPU : ComputerPart
    {
        public CPU(string name, string manufacturer, int cores) : base(name, manufacturer)
        {
            Cores = cores;
        }

        public int Cores { get; }
    }
}