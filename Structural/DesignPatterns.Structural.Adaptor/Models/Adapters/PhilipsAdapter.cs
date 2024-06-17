using DesignPatterns.Structural.Adapter.Models.Contracts;
using DesignPatterns.Structural.Adapter.Models.ThirdPartyServices;

namespace DesignPatterns.Structural.Adapter.Models.Adapters
{
    /// <summary>
    /// The Adapter
    /// Follows Class Adapter approach, which uses inheritance to interact with the Third party service.
    /// This approach can force you into Multiple Inheritance, hence Object Adapter approach is recommended.
    /// </summary>
    public class PhilipsAdapter : PhilipsTelevision, IGenericTVInterface
    {

        public void ConnectToWifi(string ssid, string name, string password, bool connectAutomatically, bool isPasswordSaved)
        {
            base.ConnectToWifi(new NetworkCredentials()
            {
                SSID = ssid,
                Name = name,
                Password = password,
                ConnectAutomatically = connectAutomatically,
                IsPasswordSaved = isPasswordSaved
            });
        }

        public void OpenMenu()
        {
            base.OpenMenu();
        }

        public void ScanWifiNetworks()
        {
            base.ScanWifiNetworks();
        }

        public void TurnOff()
        {
            base.TurnOff();
        }

        public void TurnOn()
        {
            base.TurnOn();
        }
    }
}
