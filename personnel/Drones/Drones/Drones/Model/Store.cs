namespace Drones
{
    public partial class Store : Building
    {
        private string[] OpeningHours;
        public Store(int posX, int posY, int Width, int Height, string[] OpeningHours) : base(posX, posY, Width, Height)
        {
            this.OpeningHours = OpeningHours;
        }
    }
}