using Facade.Modulo_1;

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

            int identificador = int.Parse(Console.ReadLine());
                if (identificador == 5)
                {
                    continuar = false;
                }
                else 

                { 
                    Console.WriteLine("Ingrese los numeros que quiera hacer la operacion");
                    double numero1 = int.Parse(Console.ReadLine());
                    double numero2 = int.Parse(Console.ReadLine());
                    CContexto context = new CContexto(CFabrica.fabri(identificador));

                    context.ejecutar(numero1, numero2);
                }

        }
    }
}