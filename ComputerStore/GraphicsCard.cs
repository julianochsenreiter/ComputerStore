namespace ComputerStore
{
    public class GraphicsCard : ComputerPart
    {
        public GraphicsCard(string name, string manufacturer, bool integrated) : base(name, manufacturer)
        {
            Integrated = integrated;
        }

        public bool Integrated { get; }
    }
}