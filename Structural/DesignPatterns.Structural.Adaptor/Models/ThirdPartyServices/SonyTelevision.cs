namespace DesignPatterns.Structural.Adapter.Models.ThirdPartyServices
{
    /// <summary>
    /// Sony Television - Adaptee
    /// </summary>
    public class SonyTelevision
    {
        public void MenuControls()
        {
            Console.WriteLine("opening menu...");
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
            Console.WriteLine("Sony: Our screens are so good, even Spiderman can't look away!");
        }
        public void TurnOffInMinutes(int minutes)
        {
            Console.WriteLine($"turning off in {minutes} minutes...");
        }
        public void ConnectToWifi(NetworkCredentials credentials)
        {
            Console.WriteLine($"connecting to {credentials.Name}...");
        }
        public void ConnectToWifi(string ssid)
        {
            //gets the network details which are stored in the television internal memory.
            //connect to the network using the fetched details.
            Console.WriteLine($"connecting to {ssid}...");
        }
    }
}
