using static System.Net.Mime.MediaTypeNames;
using System.Text;
using BoatNamespace;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static void Main()
        {

            
            IBoat boat = new Boat("CargoShip", 10000, 30);
            IContainer container1 = new SensitiveContainer(1, 500, "Red");
            IContainer container2 = new RefrigeratedContainer(2, 600, "Blue");
            IContainer container3 = new TankContainer(3, 1000, "Oil", "Black");

            boat.Start();
            boat.LoadContainer(container1);
            boat.LoadContainer(container2);
            boat.LoadContainer(container3);

            container1.ViewContent();
            container2.ViewContent();
            container3.ViewContent();

            boat.UnloadContainer(container1);
            boat.UnloadContainer(container1);
        }
    }
}
