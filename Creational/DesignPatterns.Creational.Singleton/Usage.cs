/*
 * Singleton design pattern lets you ensure that a class has only one instance while providing a global access point to this instance.
 */
using DesignPatterns.Creational.Singleton.Models;
using static DesignPatterns.Creational.Singleton.Models.AudioDriverService;

namespace DesignPatterns.Creational.Singleton
{
    public class Usage
    {
        public async static Task Main()
        {

            await Task.WhenAll(Task.Run(() =>
            {
                AudioDriverService driver = DriverInstance;
                Console.WriteLine(driver.InstanceId);
            }),
            Task.Run(() =>
            {
                AudioDriverService driver = DriverInstance;
                Console.WriteLine(driver.InstanceId);
            }),
            Task.Run(() =>
            {
                AudioDriverService driver = DriverInstance;
                Console.WriteLine(driver.InstanceId);
            }));
        }
    }
}
