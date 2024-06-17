namespace DesignPatterns.Structural.Adapter.Models.Contracts
{
    public interface IGenericTVInterface
    {
        void OpenMenu();
        void ScanWifiNetworks();
        void TurnOff();
        void TurnOn();
        void ConnectToWifi(string ssid, string name, string password, bool connectAutomatically, bool isPasswordSaved);   
    }
}
