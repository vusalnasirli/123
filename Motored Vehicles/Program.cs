using System;

namespace Motored_Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Default Model" , " Default User " , new DateTime(2022));
            Console.WriteLine(car);

            
        }
    }
}
