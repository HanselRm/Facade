using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Modulo2
{
    internal static class CConvertidor
    {
        public static void fahrenheitToCelsius(double grados)
        {
            Console.WriteLine(((grados - 32) * 5 / 9) + " Grados Celsius");
        }

        public static void fahrenheitToKelvin(double grados)
        {
            Console.WriteLine(((grados - 32) * 5 / 9 + 273.15) + " Grados Kelvin");
        }

        public static void kelvinTofahrenheit(double grados)
        {
            Console.WriteLine( ((grados - 273.15) * 9 / 5 + 32) + " Grados Fahrenheit");
        }

        public static void kelvinToCelsius(double grados)
        {
            Console.WriteLine((grados - 273.15) + " Grados Celsius");
        }

        public static void CelsiusToFahrenheit(double grados)
        {
            Console.WriteLine(((grados * 9 / 5) + 32) + " Grados Fahrenheit");
        }

        public static void CelsiusToKelvin(double grados)
        {
            Console.WriteLine((grados + 273.15) + " Grados Kelvin");
        }
    }
}
