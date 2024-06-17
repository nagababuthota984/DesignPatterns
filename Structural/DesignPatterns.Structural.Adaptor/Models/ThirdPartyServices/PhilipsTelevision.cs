using DesignPatterns.Structural.Adapter.Models.Contracts;

namespace DesignPatterns.Structural.Adapter.Models.ThirdPartyServices
{
    /// <summary>
    /// Philips Television - Adaptee or Service that can't be directly used by the Client.
    /// </summary>
    public class PhilipsTelevision
    {
        public void TurnOn()
        {
            Console.WriteLine("turning on...");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Watch the world through Philips!");
        }

        public void TurnOff()
        {
            Console.WriteLine("turning off...");
        }

        public void OpenMenu()
        {
            Console.WriteLine("Menu opened");
        }

        public void ScanWifiNetworks()
        {
            Console.WriteLine("Scanning for wifi networks nearby...");
        }

        public void OpenNetflixApp()
        {
            Console.WriteLine("searching for Netflix app in the app library...");
            Console.WriteLine("Opening netflix...");
        }

        public void ConnectToWifi(NetworkCredentials credentials)
        {
            Console.WriteLine($"connecting to {credentials.Name}...");
        }
    }
}
