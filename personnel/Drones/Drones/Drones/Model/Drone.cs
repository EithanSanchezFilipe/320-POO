namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone : IExpellable
    {


        public static readonly int FULLCHARGE = 1000;  // La charge actuelle de la batterie
        private string _name;                           // Un nom
        public int Charge;
        private int _x;                                 // Position en X depuis la gauche de l'espace aérien
        private int _y;                                 // Position en Y depuis le haut de l'espace aérien
        public bool LowBattery { get; private set; }
        private Rectangle _evacuateZone;
        private Rectangle _droneRectangle;
        public EvacuationState EvacuationState { get; private set; }

        public string Name { get => _name; set => _name = value; }
        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }

        public Drone(int x, int y, string name)
        {
            _name = name;
            _x = x;
            _y = y;
            Charge = FULLCHARGE;
            EvacuationState = EvacuationState.Free;
        }
        public Drone(int x, int y)
        {
            _name = "bob";
            _x = x;
            _y = y;
            Charge = FULLCHARGE;
            _droneRectangle = new Rectangle(_x, _y, Helper.DroneSize, Helper.DroneSize);
        }

        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
            _x += 2;                                    // Il s'est déplacé de 2 pixels vers la droite
            _y += Helper.alea.Next(-2, 3);              // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
            Charge--;                                  // Il a dépensé de l'énergie
            if (Charge == FULLCHARGE / 5)
                LowBattery = true;
        }

        public bool Evacuate(Rectangle zone)
        {
            _evacuateZone = zone;
            if (_droneRectangle.IntersectsWith(_evacuateZone))
            {

                EvacuationState = EvacuationState.Evacuating;
                return false;
            }
            else
            {
                EvacuationState = EvacuationState.Free;
                return true;
            }

        }

        public void FreeFlight()
        {
            _evacuateZone = Rectangle.Empty;
            EvacuationState = EvacuationState.Free;
        }

        public EvacuationState GetEvacuationState()
        {
            return EvacuationState;
        }
    }
}
