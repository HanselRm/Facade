using Facade.Modulo_3;
using Facade.Modulo2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Modulo_1
{
    internal static class CFacadeGeneral
    {
        public static void FacadeGeneral()
        {
            Boolean continuar = true;

            while (continuar)
            {
                Console.Clear();
            Console.WriteLine(@"
            Seleccione la opcion
            1- Sumadora
            2- Convertidor 
            3- formulario de registro
            4- salir
            ");

                int opcion = int.Parse(Console.ReadLine()??"");

            switch (opcion)
                {
                    case 1:
                        FacadeModulo1.Menu();
                        break;

                    case 2:
                        FacadeModulo2.Menu();
                    break;

                    case 3:
                        FacadeModulo3.Menu();
                    break;

                    case 4:
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
