using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    internal static class Helper
    {
        public static int DroneSize = 8;
        public static List<Color> SmartiesColors = new List<Color>{Color.Red, Color.Yellow, Color.Blue, Color.Brown, Color.Orange};
        public const int BOX_PROD_DELAY = 5000;
        public static Random alea = new Random();
    }
}
