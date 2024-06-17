using DesignPatterns.Structural.Facade.Modules;

namespace DesignPatterns.Structural.Facade
{
    public class AudioMangerFacade(AudioUnit AudioService, AuthenticationService AuthService, FileProvider FileService)
    {
        public MemoryStream Recording { get; set; }

        public void StartRecording()
        {
            if (!AuthService.IsAuthenticated())
                return;
            AudioService.TurnMicOn();
            Recording = AudioService.GetLiveFeed();
        }

        public void StopRecording()
        {
            AudioService.TurnMicOff();
        }

        public void SaveRecording()
        {
            AudioService.TurnMicOff();
            Byte[] bytes = Recording.ToArray();
            if (!AuthService.IsAuthenticated())
                return;
            FileService.SaveFile(bytes);
        }
    }
}
