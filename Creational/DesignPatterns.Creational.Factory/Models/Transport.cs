namespace DesignPatterns.Creational.Factory.Models
{
    //the product interface
    public abstract class Transport
    {
        public int Id { get; set; }
        public string AgencyName { get; set; }
        public int Capacity { get; set; }
        public long GPSLocationIdentifier { get; set; }
        public abstract bool Deliver();
    }

    public class Truck : Transport
    {
        //usually these concrete products might have some functionality which differs from each other.
        //so this pattern is not only about creating a different product, but also having some core logic which differs from product to product.
        public string DriverPhone { get; set; }

        public string VehicleNumber { get; set; }

        public override bool Deliver()
        {
            Console.WriteLine("Delivered via road transport");
            return true;
        }
    }
    public class Ship : Transport
    {
        public string ShipIdentifier { get; set; }

        public override bool Deliver()
        {
            Console.WriteLine("Delivered via ship transport");
            return true;
        }
    }
}

