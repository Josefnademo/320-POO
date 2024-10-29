using static System.Net.Mime.MediaTypeNames;
using System.Text;
using System.ComponentModel;

namespace BoatNamespace
{
    public class Container : IContainer
    {
        public int Id { get; private set; }
        public float Weight { get; private set; }
        public bool IsRefrigerated { get; private set; }
        public List<string> Merchandise { get; private set; }
        public string Color { get; private set; }

        public Container(int id, float weight, bool isRefrigerated, string color)
        {
            Id = id;
            Weight = weight;
            IsRefrigerated = isRefrigerated;
            Color = color;
            Merchandise = new List<string>();
        }

        public void ViewContent()
        {
            Console.WriteLine($"Container ID: {Id}, Color: {Color}, Weight: {Weight}kg, Refrigerated: {IsRefrigerated}");
            Console.WriteLine("Merchandise inside:");
            foreach (var item in Merchandise)
            {
                Console.WriteLine($"- {item}");
            }
        }

        public void AddMerchandise(string item)
        {
            Merchandise.Add(item);
            Console.WriteLine($"Added {item} to Container ID: {Id}");
        }
    }
}



namespace BoatNamespace
{

    public class SensitiveContainer : Container
    {
        public SensitiveContainer(int id, float weight, string color)
            : base(id, weight, true, color) // IsRefrigerated est true
        {
        }
    }
}

namespace BoatNamespace
{
    public class RefrigeratedContainer : Container
    {
        public RefrigeratedContainer(int id, float weight, string color)
            : base(id, weight, true, color) // IsRefrigerated est true
        {
        }
    }
}


namespace BoatNamespace
{
    public class TankContainer : Container
    {
        public string LiquidType { get; private set; }

        public TankContainer(int id, float weight, string liquidType, string color)
            : base(id, weight, true, color) // IsRefrigerated est true
        {
            LiquidType = liquidType;
        }
    }
}
