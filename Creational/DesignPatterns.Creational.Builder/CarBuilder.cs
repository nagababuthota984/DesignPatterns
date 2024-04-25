using DesignPatterns.Creational.Builder.Models;

namespace DesignPatterns.Creational.Builder
{
    public class CarBuilder : IBuilder<Car>
    {
        public Car Car { get; set; }
        public CarBuilder()
        {
            Car = new Car();
        }
        public void Reset()
        {
            Car = new();
        }

        public void SetEngine(Engine engine)
        {
            Car.Engine = engine;
        }

        public void SetGPSModule(GPSModule gpsModule)
        {
            Car.GPSModule = gpsModule;
        }

        public void SetSeats(int seats)
        {
            Car.SeatsCount = seats;
        }

        public void SetTripComputer(TripComputer tripComputer)
        {
            Car.TripComputer = tripComputer;
        }

        public Car GetResult()
        {
            return Car;
        }
    }
}