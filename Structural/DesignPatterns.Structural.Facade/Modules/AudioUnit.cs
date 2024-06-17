namespace DesignPatterns.Structural.Facade.Modules
{
    public class AudioUnit
    {
        public void TurnMicOn()
        {
            Console.WriteLine("turning mic on...");
        }
        public void TurnMicOff()
        {
            Console.WriteLine("turning mic off...");
        }
        public MemoryStream GetLiveFeed()
        {
            Console.WriteLine("live audio feed...");
            return new MemoryStream();
        }
    }
}
