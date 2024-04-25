using DesignPatterns.Creational.Builder.Models;

namespace DesignPatterns.Creational.Builder
{
    public class CarManualBuilder : IBuilder<CarManual>
    {
        public CarManual CarManual { get; set; }
        public CarManualBuilder()
        {
            CarManual = new CarManual();
        }
        public CarManual GetResult()
        {
            return CarManual;
        }

        public void Reset()
        {
            CarManual = new CarManual();
        }

        public void SetEngine(Engine engine)
        {
            CarManual.EngineSection = $"v{engine.Cylinders} engine with {engine.Capacity}cc, {engine.HorsePower}hp and {engine.TorqueNm} Torque N-m";
        }

        public void SetGPSModule(GPSModule gpsModule)
        {
            CarManual.GPSModuleSection = string.Empty;
        }

        public void SetSeats(int seats)
        {
            CarManual.SeatsSection = string.Empty;
        }

        public void SetTripComputer(TripComputer tripComputer)
        {
            CarManual.TripComputerSection = string.Empty;
        }
    }
}
