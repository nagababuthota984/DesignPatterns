using DesignPatterns.Creational.Builder.Models;

namespace DesignPatterns.Creational.Builder
{
    /// <summary>
    /// The Director class
    /// Defines the order in which to call construction steps, so you can reuse specific configurations of products
    /// </summary>
    public class Director
    {
        private readonly IBuilder<Car> _carBuilder;
        private readonly IBuilder<CarManual> _carManualBuilder;

        public Director()
        {
            _carBuilder = new CarBuilder();
            _carManualBuilder = new CarManualBuilder();
        }

        public Car BuildNormalCar()
        {
            _carBuilder.Reset();
            _carBuilder.SetEngine(new NormalEngine(8, 1600, 950, 1200, FuelType.Diesel));
            _carBuilder.SetSeats(5);
            _carBuilder.SetGPSModule(new GPSModule());
            _carBuilder.SetTripComputer(new TripComputer());
            Car car = _carBuilder.GetResult();
            car.Manual = BuildCarManual(car);
            return car;
        }



        public Car BuildSportsCar()
        {
            _carBuilder.Reset();
            _carBuilder.SetEngine(new SportsEngine(12, 2500, 1800, 2400, FuelType.Gasoline, true));
            _carBuilder.SetSeats(2);
            _carBuilder.SetGPSModule(new GPSModule());
            Car car = _carBuilder.GetResult();
            return car;
        }

        public CarManual BuildCarManual(Car car)
        {
            _carManualBuilder.Reset();
            _carManualBuilder.SetEngine(car.Engine);
            _carManualBuilder.SetSeats(car.SeatsCount);
            _carManualBuilder.SetGPSModule(car.GPSModule);
            _carManualBuilder.SetTripComputer(car.TripComputer);
            return _carManualBuilder.GetResult();
        }

    }
}
