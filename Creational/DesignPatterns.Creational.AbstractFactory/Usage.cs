/*
 *  Abstract Factory is a creational design pattern which provides an interface to create a family of related objects
 *  Each family kind can implement the interface and create their own family of objects.
 *  
 */


using DesignPatterns.Creational.AbstractFactory.Models;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Usage
    {
        static FurniturePack Main(string args)
        {
            IFurnitureFactory factory = null;
            if (args == "Minimalist")
            {
                factory = new MinimalistFurnitureFactory();
                Chair minChair = factory.CreateChair();
                Sofa minSofa = factory.CreateSofa();
                CoffeeTable minCoffeeTable = factory.CreateCoffeeTable();
                return FurniturePack.Build(minChair, minSofa, minCoffeeTable);
            }
            else if(args == "Victorian")
            {
                factory = new VictorianFurnitureFactory();  
                Chair vicChair = factory.CreateChair();
                Sofa vicSofa = factory.CreateSofa();
                CoffeeTable vicCoffeeTable = factory.CreateCoffeeTable();
                return FurniturePack.Build(vicChair, vicSofa, vicCoffeeTable);
            }
            return default;
        }

    }
    public class FurniturePack
    {
        public Chair Chair { get; set; }
        public Sofa Sofa { get; set; }
        public CoffeeTable CoffeeTable { get; set; }

        public static FurniturePack Build(Chair chair, Sofa sofa, CoffeeTable coffeeTable)
        {
            return new FurniturePack
            {
                Sofa = sofa,
                CoffeeTable = coffeeTable,
                Chair = chair,
            };
        }
    }
}
