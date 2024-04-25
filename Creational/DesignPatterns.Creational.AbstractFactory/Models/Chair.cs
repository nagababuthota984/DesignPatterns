namespace DesignPatterns.Creational.AbstractFactory.Models
{
    /// <summary>
    /// Abstract Product
    /// Declare interfaces for a set of distint but related products which make up a product family.
    /// </summary>
    public class Chair
    {
        public bool HasHandRest { get; set; }
        public bool HasHeadRest { get; set; }
    }

    /// <summary>
    /// Concrete product 1
    /// One variant of abstract product.
    /// </summary>
    public class VictorianChair : Chair
    {

    }

    /// <summary>
    /// Concrete product 2
    /// Another variant of abstract product.
    /// </summary>
    public class MinimalistChair : Chair
    {

    }
}
