using Facade.Modulo_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Modulo2
{
    internal static class FacadeModulo2
    {
        public static void Menu()
        {

            Boolean continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine(@"
                Seleccione la opcion
                1- Fahrenheit a Celsius
                2- Fahrenheit a Kelvin
                3- Kelvin a fahrenheit
                4- Kelvin a Celsius
                5- Celsius a Fahrenheit
                6- Celsius a Kelvin
                7- Salir
                ");

                int identificador = int.Parse(Console.ReadLine() ?? "");

                double grados = 0;
                if (identificador < 7)
                {
                    Console.WriteLine("Introducir grados");
                    grados = double.Parse(Console.ReadLine() ?? "");
                }
                

                switch (identificador)
                {
                    case 1:
                        CConvertidor.fahrenheitToCelsius(grados);
                        Console.ReadKey();
                        break;

                    case 2:
                        CConvertidor.fahrenheitToKelvin(grados);
                        Console.ReadKey();
                        break;

                    case 3:
                        CConvertidor.kelvinTofahrenheit(grados);
                        Console.ReadKey();
                        break;

                    case 4:
                        CConvertidor.kelvinToCelsius(grados);
                        Console.ReadKey();
                        break;

                    case 5:
                        CConvertidor.CelsiusToFahrenheit(grados);
                        Console.ReadKey();
                        break;

                    case 6:
                        CConvertidor.CelsiusToKelvin(grados);
                        Console.ReadKey();
                        break;

                    case 7:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        Console.ReadKey();
                    break;
                }
        
            }
       
        }

    }

}
