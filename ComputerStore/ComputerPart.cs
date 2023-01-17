namespace ComputerStore
{
    public abstract class ComputerPart
    {
        public ComputerPart(string name, string manufacturer)
        {
            Name = name;
            Manufacturer = manufacturer;
        }

        public string Name { get; }
        public string Manufacturer { get; }

        public override string ToString()
        {
            return $"{Name} ({Manufacturer})";
        }
    }
}