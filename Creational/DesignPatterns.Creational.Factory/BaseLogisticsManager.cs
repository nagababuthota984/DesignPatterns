using DesignPatterns.Creational.Factory.Models;

namespace DesignPatterns.Creational.Factory
{
    /// <summary>
    /// Abstract Creator
    /// </summary>
    public abstract class BaseLogisticsManager : ILogisticsManager
    {
        public abstract Transport CreateTransport();

        public void PlanDelivery()
        {
            Console.WriteLine("Item has been picked up by the transport agency");
            Console.WriteLine("Reaching your nearest destination...");
            Console.WriteLine("Reaching your nearest destination...");
            Console.WriteLine("Item has been delivered successfully");
        }
    }
}
