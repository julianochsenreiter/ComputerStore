namespace ComputerStore
{
    public class Harddisk : ComputerPart
    {
        public Harddisk(string name, string manufacturer, bool ssd) : base(name, manufacturer)
        {
            SSD = ssd;
        }

        public bool SSD { get; }
    }
}