using DesignPatterns.Structural.Adapter.Models.Contracts;

namespace DesignPatterns.Structural.Adapter.Models.ThirdPartyServices
{
    /// <summary>
    /// Samsung Television - Adaptee or Service that can't be directly used by the Client.
    /// </summary>
    public class SamsungTelevision
    {
        public void OpenMenu()
        {
            Console.WriteLine("menu opened");
        }
        public void ScanWifiNetworks()
        {
            Console.WriteLine("scanning for wifi networks nearby...");
        }
        public void TurnOff()
        {
            Console.WriteLine("turning off...");
        }
        public void TurnOn()
        {
            Console.WriteLine("turning on...");
            Console.WriteLine("Hello, there!");
            Console.WriteLine("Samsung: Because Apple can't make TVs, they just make TV shows!");
        }
        public void ConnectToWifi(string networkId)
        {
            Console.WriteLine($"connecting to {networkId}...");
        }
    }
}
