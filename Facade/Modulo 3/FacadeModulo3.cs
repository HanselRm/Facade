using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Modulo_3
{
    internal static class FacadeModulo3
    {
        public static void Menu()
        {
            List<CPersonas> p = new List<CPersonas>();

            Boolean continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine(@"
                Seleccione la opcion
                1- Registar
                2- Lista de Personas
                3- Guardar en Excel
                4- salir
                ");

                int identificador = int.Parse(Console.ReadLine() ?? "");


                switch (identificador)
                {
                    case 1:
                        p = CManejadorPersonas.registrarPersonas(p);
                    break;

                    case 2:
                        CManejadorPersonas.mostrarPersonas(p);
                    break;

                    case 3:
                        CManejadorPersonas.guardar(p);
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
