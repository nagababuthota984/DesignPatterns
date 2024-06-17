namespace DesignPatterns.Structural.Facade.Modules
{
    public class FileProvider
    {
        public void OpenFilePicker()
        {
            Console.WriteLine("opening file picker...");
        }
        public void SaveFile(Byte[] bytes)
        {
            Console.WriteLine("saving the file...");
        }
    }
}
