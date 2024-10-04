
using Drones.Model;

namespace Drones
{
    public partial class Factory : Building
    {
        private float _powerConsumption;
        public static int id;
        private int _boxProdTimer;
        public Factory(int posX, int posY, int Width, int Height, float PowerConsumption) : base(posX, posY, Width, Height)
        {
            ++id;
            this._powerConsumption = PowerConsumption;
            Show();
        }
        public void Show()
        {
            Console.WriteLine(_powerConsumption);
        }
        public void Update(int interval, Dispatch dispatch)
        {
            _boxProdTimer += interval;
            if(_boxProdTimer >= Helper.BOX_PROD_DELAY + Helper.alea.Next(0, 1500))
            {
                Console.WriteLine("A box is being created");
                Box box = new Box(dispatch);
                _boxProdTimer = 0;
            }

        }
    }
}
