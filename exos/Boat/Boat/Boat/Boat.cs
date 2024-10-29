using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace BoatNamespace
{
    public class Boat : IBoat
    {
        public string Name { get; private set; }
        public float MaxCargoWeight { get; private set; }
        public int MaxSpeed { get; private set; }
        private List<IContainer> containers;

        public Boat(string name, float maxCargoWeight, int maxSpeed)
        {
            Name = name;
            MaxCargoWeight = maxCargoWeight;
            MaxSpeed = maxSpeed;
            containers = new List<IContainer>();
        }

        public void Start()
        {
            Console.WriteLine($"{Name} is starting.");
        }

        public bool LoadContainer(IContainer container)
        {
            float currentWeight = 0;
            foreach (var c in containers)
            {
                currentWeight += c.Weight;
            }
            
            if (currentWeight + container.Weight <= MaxCargoWeight)
            {
                containers.Add(container);
                Console.WriteLine($"Loaded container {container.Id}.");
                return true;
            }

            Console.WriteLine($"Cannot load container {container.Id}. Max cargo weight exceeded.");
            return false;
        }

        public bool UnloadContainer(IContainer container)
        {
            if (containers.Remove(container))
            {
                Console.WriteLine($"Unloaded container {container.Id}.");
                return true;
            }

            Console.WriteLine($"Container {container.Id} not found on the boat.");
            return false;
        }
    }
}