using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Modulo_3
{
     static class ManejadorPersonas
    {
        public static void registrarPersonas(CPersonas p)
        {
            Console.WriteLine( "Ingrese los siguientes datos");

            Console.WriteLine("Nombre");
                p.Nombre = Console.ReadLine()??"";

            Console.WriteLine("Apellido");
                p.Apellido = Console.ReadLine() ?? "";

            Console.WriteLine("Fecha Nacimiento");
                p.FechaNacimiento = DateTime.Parse(Console.ReadLine()??"");

            Console.WriteLine("Provincia");
                p.Provincia = Console.ReadLine()??"";

        }       
    }
}
