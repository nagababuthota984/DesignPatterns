/*
 * Adapter design pattern allows objects with incompatible interfaces to collaborate.
 * i.e, adapts the already existing interfaces to the ClientInterface needs.
 */

using DesignPatterns.Structural.Adapter.Models.Adapters;
using DesignPatterns.Structural.Adapter.Models.Contracts;
using DesignPatterns.Structural.Adapter.Models.ThirdPartyServices;

namespace DesignPatterns.Structural.Adapter
{
    public class Usage
    {
        public static void Main()
        {
            IGenericTVInterface genericTvInterface = new SamsungAdapter(new SamsungTelevision());
            genericTvInterface.TurnOn();
            genericTvInterface.ScanWifiNetworks();
            genericTvInterface.ConnectToWifi("TP-LINK-3975", "JioNetwork", string.Empty, true, true);
            genericTvInterface.OpenMenu();
            genericTvInterface.TurnOff();

        }

    }
}
