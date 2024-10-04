using Drones.Model;

namespace Drones
{
    public interface IDispatchable
    {
        // Signal the limits of the no-fly zone 
        // Return true if the drone is already outside the zone
        List<Box> Boxes { get; set; }
        // Terminate the no-fly zone
        public void CreateBox(Box box);

        // Interrogate the drone
        public void RemoveBox(Box box);
    }
}
