namespace DesignPatterns.Structural.Facade
{
    /// <summary>
    /// Facade is a structural design pattern that provides a simplified interface to a library or a framework or a complex set of classes.
    /// </summary>
    public class Usage
    {
        public static void Main()
        {
            AudioMangerFacade facade = new AudioMangerFacade(new(), new(), new());
            facade.StartRecording();
            Console.WriteLine("recording has been started..." +
                "\npress q to stop recording" +
                "\npress qw to stop and save the recording");
            string input = Console.ReadLine()!;
            if (input.Equals("q", StringComparison.OrdinalIgnoreCase))
                facade.StopRecording();
            if (input.Equals("qw", StringComparison.OrdinalIgnoreCase))
                facade.SaveRecording();

        }
    }
}
