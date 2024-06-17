namespace DesignPatterns.Structural.Adapter.Models
{
    public class NetworkCredentials
    {
        public string SSID { get; set; }
        public string Name { get; set; }
        public bool IsPasswordSaved { get; set; }
        public bool ConnectAutomatically { get; set; }
        public string Password { get; set; }
    }
}
