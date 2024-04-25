/*
 * Prototype is a creational design pattern that lets you create copies of existing objects without making your code dependent on their classes.
 */

using DesignPatterns.Creational.Prototype.Models;

namespace DesignPatterns.Creational.Prototype
{
    public class Usage
    {
        public static void Main()
        {
            /*
             * In this example, inheritance is not being used. We can implement this pattern in inheritance hierarchies and
             * A subclass may call the parent’s cloning method before copying its own field values to the resulting object.
             */
            QuoteService quoteService = new QuoteService();
            IQuotation quote = quoteService.Create(1, "#QY4531", 355.5m, DateTime.Now.AddDays(30));
            IQuotation quoteCopy = (IQuotation)quote.Clone();
            Console.WriteLine(quoteCopy.Code);
        }

    }
}
