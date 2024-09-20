namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Cr�ation de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            List<Building> buildings = new List<Building>();
            string[] openingHours = { "Lundi: 8h-18h", "Mardi: 8h-18h", "Mercredi: 8h-18h" };
            fleet.Add(new Drone(AirSpace.WIDTH / 2, AirSpace.HEIGHT / 2, "Joe"));
            buildings.Add(new Store(200, 200, 50, 50, openingHours));
            buildings.Add(new Factory(400, 400, 50, 50, 154));
            // D�marrage
            Application.Run(new AirSpace(fleet, buildings));
        }
    }
}