namespace Drones
{
    public partial class Building
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Building(int posX, int posY, int Width, int Height)
        {
            X = posX;
            Y = posY;
            this.Height = Height;
            this.Width = Width;
        }

    }
}
