namespace Drones
{
    public partial class Factory : Building
    {
        private float _powerConsumption;
        public static int id;
        private int _boxProdTimer;
        private int _boxId;
        public Factory(int posX, int posY, int Width, int Height, float PowerConsumption) : base(posX, posY, Width, Height)
        {
            ++id;
            this._powerConsumption = PowerConsumption;
        }
        public void Update(int interval, Dispatch dispatch)
        {
            _boxProdTimer += interval;
            if(_boxProdTimer >= Helper.BOX_PROD_DELAY + Helper.alea.Next(0, 1500))
            {
                Box box = new Box(dispatch, _boxId, Helper.alea.Next(5,10), Helper.SmartiesColors[Helper.alea.Next(0,4)]);
                _boxProdTimer = 0;
                _boxId++;
            }

        }
    }
}
