using DesignPatterns.Creational.Builder.Models;

namespace DesignPatterns.Creational.Builder
{
    /// <summary>
    /// Builder associated with the assembly process
    /// defines the steps to build a particular product in this assembly unit
    /// </summary>
    /// <typeparam name="T">Type of product to build</typeparam>
    public interface IBuilder<T>
    {
        void Reset();
        void SetSeats(int seats);
        void SetEngine(Engine engine);
        void SetTripComputer(TripComputer tripComputer);
        void SetGPSModule(GPSModule gpsModule);
        T GetResult();
    }
}
