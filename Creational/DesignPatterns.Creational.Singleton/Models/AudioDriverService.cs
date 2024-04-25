namespace DesignPatterns.Creational.Singleton.Models
{
    public sealed class AudioDriverService
    {
        private static AudioDriverService? _driverInstance = null;
        private static readonly object _lock = new object();
        public Guid InstanceId { get; private set; }

        public static AudioDriverService DriverInstance
        {
            get
            {
                if (_driverInstance is null)
                {
                    lock (_lock)
                    {
                        if (_driverInstance is null)
                            _driverInstance = new AudioDriverService();
                    }
                }
                return _driverInstance;
            }
        }
        private AudioDriverService()
        {
            InstanceId = Guid.NewGuid();
        }

        /*
         * We can write a nested class here and expose method which can return the AudioDriverService, need to look into this
         */
    }
}
