namespace ComputerStore
{
    public class ComputerCase : ComputerPart
    {
        public ComputerCase(string name, string manufacturer, string format) : base(name, manufacturer)
        {
            Format = format;
        }

        public string Format { get; }
    }
}