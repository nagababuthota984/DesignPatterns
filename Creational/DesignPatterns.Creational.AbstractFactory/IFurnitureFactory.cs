using DesignPatterns.Creational.AbstractFactory.Models;

namespace DesignPatterns.Creational.AbstractFactory
{
    /// <summary>
    /// Abstract Factory
    /// Declares a set of methods for creating each of the abstract products.
    /// </summary>
    public interface IFurnitureFactory
    {
        Chair CreateChair();
        Sofa CreateSofa();
        CoffeeTable CreateCoffeeTable();

    }
}
