using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Modulo_1
{
     class CContexto
    {
         ISumadora sum;

        public CContexto(ISumadora Object)
        {
            sum = Object;
        }

        public  void ejecutar(double numero1, double numero2)
        {

            sum.operacion(numero1, numero2);
        }
    }
}
