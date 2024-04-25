using DesignPatterns.Creational.AbstractFactory.Models;

namespace DesignPatterns.Creational.AbstractFactory
{
    /// <summary>
    /// Concrete Factory 1
    /// Variant - Minimalism
    /// </summary>
    public class MinimalistFurnitureFactory : IFurnitureFactory
    {
        public Chair CreateChair()
        {
            return new MinimalistChair();
        }

        public CoffeeTable CreateCoffeeTable()
        {
            return new MinimalistCoffeeTable();
        }

        public Sofa CreateSofa()
        {
            return new MinimalistSofa();
        }
    }
}
