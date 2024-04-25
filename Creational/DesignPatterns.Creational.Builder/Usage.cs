/*
 *  Builder is a creational design pattern that lets you construct an object step by step.
 *  This pattern allows you produce different types and representations using the same construction code
 */

using DesignPatterns.Creational.Builder.Models;

namespace DesignPatterns.Creational.Builder
{
    public class Usage
    {
        /*
         * Extract the object construction code out of its own class and move it to separate objects called builders.
         */
        static void Build()
        {
            /*
             * Optionally - you can have a class called Director, which defines the order of steps
             */
            Director director = new Director();

            Car car = director.BuildNormalCar();
            CarManual carManual = director.BuildCarManual(car);
            Car sportsCar = director.BuildSportsCar();
            CarManual sportCarManual = director.BuildCarManual(sportsCar);
        }

    }
}
