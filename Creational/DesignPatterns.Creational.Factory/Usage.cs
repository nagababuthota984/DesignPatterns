/*
 *  Factory Method is a creational design pattern that provides an interface for creating objects in a superclass
 *  which allows subclasses to alter the type of objects that will be created
 *  
 */
using DesignPatterns.Creational.Factory.Models;

namespace DesignPatterns.Creational.Factory
{
    public class Usage
    {
        static void Main(string args)
        {
            //Here based on the transport suitable,
            //1. Transport objects are being created, without being tightly coupled.
            //2. Each transport object has its own transport logic which differs significantly with each other.
            if (!string.IsNullOrEmpty(args) && args.Contains("road"))
            {
                Console.WriteLine("Order1 placed");
                Console.WriteLine("Road Transport possible");
                BaseLogisticsManager logistics = new RoadLogisticsManager();
                Transport truck = logistics.CreateTransport();
                truck.Deliver();
            }
            else
            {
                Console.WriteLine("Order1 placed");
                Console.WriteLine("Sea Transport possible");
                BaseLogisticsManager logistics = new SeaLogisticsManager();
                Transport ship = logistics.CreateTransport();
                ship.Deliver();
            }

        }
    }
}
