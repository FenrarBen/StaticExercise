using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("32 F is " + TempConverter.FahrenheitToCelsius(32) + " C");
            Console.WriteLine("100 C is " + TempConverter.CelsiusToFahrenheit(100) + " F");
        }
    }
}
