using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace Facade.Modulo_3
{
     static class CManejadorPersonas
    {
        public static List<CPersonas> registrarPersonas(List<CPersonas> p)
        {
            CPersonas perso = new CPersonas();
            Console.WriteLine( "Ingrese los siguientes datos");

            Console.WriteLine("Nombre");
                perso.Nombre = Console.ReadLine()??"";

            Console.WriteLine("Apellido");
                perso.Apellido = Console.ReadLine() ?? "";

            Console.WriteLine("Fecha Nacimiento en formato dd/MM/yyyy");
                perso.FechaNacimiento = Console.ReadLine()??"";

            Console.WriteLine("Provincia");
                perso.Provincia = Console.ReadLine()??"";

            p.Add(perso);

            return p;

        }   

        public static double calcularEdad(string fecha)
        {
            DateTime fechaday = DateTime.ParseExact(fecha, "dd/MM/yyyy", null);

            DateTime FechaActual = DateTime.Now;

            TimeSpan dif = FechaActual - fechaday;
            double dias = dif.TotalDays;
            double años = dias / 365;

            dias = (int)dias;
            años = (int)años;

            return años;
        }
        
        public static void mostrarPersonas(List<CPersonas> p)
        {
            foreach(CPersonas person in p)
            {
                double años = calcularEdad(person.FechaNacimiento);
                Console.WriteLine(@$"
                                    Nombre: {person.Nombre} {person.Apellido}
                                    Edad: {años}
                                    Provincia: {person.Provincia}
                                    ");

                Console.WriteLine("Nombre:");
            }
        }

        public static void guardar(List<CPersonas> p)
        {
            Application excel = new Application();
            Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;

                worksheet.Cells[1,1] = "Nombre" ;
                worksheet.Cells[1, 2] = "Apellido";
                worksheet.Cells[1, 3] = "Fecha Nacimiento";
                worksheet.Cells[1, 4] = "Provincia";

                int filaActual = 2;
                foreach (CPersonas personas in p)
                {
                    worksheet.Cells[filaActual, 1] = personas.Nombre;
                    worksheet.Cells[filaActual, 2] = personas.Apellido;
                    worksheet.Cells[filaActual, 3] = personas.FechaNacimiento;
                    worksheet.Cells[filaActual, 4] = personas.Provincia;
                    filaActual++;
                }
                workbook.SaveAs("C:\\Users\\hanse\\Escritorio\\Carpetas\\Itla\\Programacion\\Facade\\Test.xlsx");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                workbook.Close();
                excel.Quit();
                Marshal.ReleaseComObject(worksheet);
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(excel);
            }
        }
    }
}
