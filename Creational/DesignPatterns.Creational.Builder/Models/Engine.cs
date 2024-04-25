namespace DesignPatterns.Creational.Builder.Models
{
    public enum FuelType
    {
        Gasoline,
        Diesel,
        Electric
    }

    public abstract class Engine
    {
        public int Cylinders { get; protected set; }
        public decimal Capacity { get; protected set; }
        public double HorsePower { get; protected set; }
        public double TorqueNm { get; protected set; }
        public FuelType FuelType { get; protected set; }
    }

    public class NormalEngine : Engine
    {
        public NormalEngine(int cylinders, decimal capacity, double horsePower, double torqueNm, FuelType fuelType)
        {
            Cylinders = cylinders;
            Capacity = capacity;
            HorsePower = horsePower;
            TorqueNm = torqueNm;
            FuelType = fuelType;
        }
    }

    public class SportsEngine : Engine
    {
        public bool Turbocharged { get; protected set; }

        public SportsEngine(int cylinders, decimal capacity, double horsePower, double torqueNm, FuelType fuelType, bool turbocharged)
        {
            Cylinders = cylinders;
            Capacity = capacity;
            HorsePower = horsePower;
            TorqueNm = torqueNm;
            FuelType = fuelType;
            Turbocharged = turbocharged;
        }
    }
}
