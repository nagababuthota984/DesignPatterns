using DesignPatterns.Structural.Adapter.Models.Contracts;
using DesignPatterns.Structural.Adapter.Models.ThirdPartyServices;

namespace DesignPatterns.Structural.Adapter.Models.Adapters
{
    /// <summary>
    /// The Adapter
    /// </summary>
    public class SamsungAdapter(SamsungTelevision SamsungTelevision) : IGenericTVInterface
    {

        public void ConnectToWifi(string ssid, string name, string password, bool connectAutomatically, bool isPasswordSaved)
        {
            SamsungTelevision.ConnectToWifi(ssid);
        }

        public void OpenMenu()
        {
            SamsungTelevision.OpenMenu();
        }

        public void ScanWifiNetworks()
        {
            SamsungTelevision.ScanWifiNetworks();
        }

        public void TurnOff()
        {
            SamsungTelevision.TurnOff();
        }

        public void TurnOn()
        {
            SamsungTelevision.TurnOn();
        }
    }
}
