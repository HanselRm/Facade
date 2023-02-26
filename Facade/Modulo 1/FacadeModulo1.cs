using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Modulo_1
{
    internal static class FacadeModulo1
    {
        public static void Menu()
        {

            Boolean continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine(@"
            Seleccione la opcion
            1- Sumar
            2- Restar
            3- Multiplicar
            4- Dividir
            5- Salir
            ");

                int identificador = int.Parse(Console.ReadLine() ?? "");

                if (identificador == 5)
                {
                    continuar = false;
                }
                else
                {
                    Console.WriteLine("Ingrese los numeros que quiera hacer la operacion");
                    double numero1 = int.Parse(Console.ReadLine() ?? "");
                    double numero2 = int.Parse(Console.ReadLine() ?? "");
                    CContexto context = new(CFabrica.fabri(identificador));

                    context.ejecutar(numero1, numero2);
                }

            }


        }
    }
}
