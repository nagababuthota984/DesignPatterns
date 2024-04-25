using DesignPatterns.Creational.AbstractFactory.Models;

namespace DesignPatterns.Creational.AbstractFactory
{
    /// <summary>
    /// Concrete Factory 2
    /// Variant - Victorian
    /// </summary>
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public Chair CreateChair()
        {
            return new VictorianChair();
        }

        public CoffeeTable CreateCoffeeTable()
        {
            return new VictorianCoffeeTable();
        }

        public Sofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }
}
