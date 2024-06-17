using DesignPatterns.Structural.Adapter.Models.Contracts;
using DesignPatterns.Structural.Adapter.Models.ThirdPartyServices;

namespace DesignPatterns.Structural.Adapter.Models.Adapters
{
    /// <summary>
    /// The Adapter
    /// Follows the Object adapter approach
    /// </summary>
    public class SonyAdapter(SonyTelevision SonyTelevision) : IGenericTVInterface
    {
        public void ConnectToWifi(string ssid, string name, string password, bool connectAutomatically, bool isPasswordSaved)
        {
            if (isPasswordSaved)
            {
                SonyTelevision.ConnectToWifi(ssid);
                return;
            }
            //adapt the inputs according to the service
            var credentials = new NetworkCredentials()
            {
                SSID = ssid,
                Name = name,
                Password = password,
                ConnectAutomatically = connectAutomatically,
                IsPasswordSaved = isPasswordSaved
            };
            SonyTelevision.ConnectToWifi(credentials);
        }

        public void OpenMenu()
        {
            SonyTelevision.MenuControls();
        }

        public void ScanWifiNetworks()
        {
            SonyTelevision.ScanWifiNetworks();
        }

        public void TurnOff()
        {
            SonyTelevision.TurnOff();
        }

        public void TurnOn()
        {
            SonyTelevision.TurnOn();
        }
    }
}
