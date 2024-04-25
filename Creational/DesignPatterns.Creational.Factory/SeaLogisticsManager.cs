using DesignPatterns.Creational.Factory.Models;

namespace DesignPatterns.Creational.Factory
{
    /// <summary>
    /// Concrete Creator 1
    /// </summary>
    public class SeaLogisticsManager : BaseLogisticsManager
    {
        public override Transport CreateTransport()
        {
            //either create an object or return from cache, object pool or another source.
            return new Ship()
            {
                ShipIdentifier = "XYZ"
            };
        }
    }
}
