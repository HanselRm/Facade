﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Modulo_1
{
    internal class CMultiplicacion : ISumadora
    {
        public void operacion(double numero1, double numero2)
        {
            Console.WriteLine("La multiplicacion es " + (numero1 * numero2));
            Console.ReadKey();
        }
    }
}
