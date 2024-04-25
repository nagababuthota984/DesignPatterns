using DesignPatterns.Creational.Factory.Models;

namespace DesignPatterns.Creational.Factory
{
    /// <summary>
    /// Concrete Creator 2
    /// </summary>
    public class RoadLogisticsManager : BaseLogisticsManager
    {
        public override Transport CreateTransport()
        {
            return new Truck()
            {
                DriverPhone = "9019109212"
            };
        }
    }
}
