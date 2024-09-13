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

            // Création de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            List<Building> buildings = new List<Building>();
            fleet.Add(new Drone(AirSpace.WIDTH / 2, AirSpace.HEIGHT / 2, "Joe"));
            buildings.Add(new Building(200, 200, 100, 100));
            // Démarrage
            Application.Run(new AirSpace(fleet, buildings));
        }
    }
}