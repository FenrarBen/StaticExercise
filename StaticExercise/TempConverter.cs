using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        static TempConverter()
        {

        }

        static public double FahrenheitToCelsius(double temp)
        {
            return ((temp - 32.0) * (5.0/9.0));
        }

        static public double CelsiusToFahrenheit(double temp)
        {
            return (temp * (9.0 / 5.0)) + 32.0;
        }
    }
}
