namespace DesignPatterns.Creational.Builder.Models
{
    public class TripComputer
    {
        // Define common properties and methods for trip computers
    }

    public class GPSModule
    {
        // Define common properties and methods for GPS modules
    }

    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SeatsCount { get; set; }
        public Engine Engine { get; set; }
        public TripComputer TripComputer { get; set; }
        public GPSModule GPSModule { get; set; }
        public CarManual Manual { get; set; }
    }
}
