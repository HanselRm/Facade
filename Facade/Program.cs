using Facade.Modulo_1;
using Facade.Modulo2;

class Program
{
    
    public static void Main(String[] args)
    {
        Boolean continuar = true;

        while (continuar) 
        {
            Console.WriteLine(@"
            Seleccione la opcion
            1- Suma
            2- Resta
            3- Multiplicacion
            4- Division
            5- salir
            ");

            int identificador = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Introducir grados");
            double grados = double.Parse(Console.ReadLine() ?? "");

            switch (identificador) 
                {
                case 1:
                    CConvertidor.fahrenheitToCelsius(grados);
                break;

                case 2:
                    CConvertidor.fahrenheitToKelvin(grados);
                break;

                case 3:
                    CConvertidor.kelvinTofahrenheit(grados); 
                break;

                case 4:
                    CConvertidor.kelvinToCelsius(grados);
                break;

                case 5:
                    CConvertidor.CelsiusToFahrenheit(grados);
                break;

                case 6:
                    CConvertidor.CelsiusToKelvin(grados);
                break;

                case 7:
                    continuar = false;
                break;



            }
                //if (identificador == 5)
                //{
                //    continuar = false;
                //}
                //else 
                //{ 
                //    Console.WriteLine("Ingrese los numeros que quiera hacer la operacion");
                //    double numero1 = int.Parse(Console.ReadLine()??"");
                //    double numero2 = int.Parse(Console.ReadLine()??"");
                //    CContexto context = new (CFabrica.fabri(identificador));

                //    context.ejecutar(numero1, numero2);
                //}

        }
    }
}