namespace Drones
{
    public partial class Factory : Building
    {
        private float PowerConsumption;
        public Factory(int posX, int posY, int Width, int Height, float PowerConsumption) : base(posX, posY, Width, Height)
        {
            this.PowerConsumption = PowerConsumption;
            Show();
        }
        public void Show()
        {
            Console.WriteLine(PowerConsumption);
        }
    }
}
