using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Modulo_1
{
    internal static class CFabrica
    {
        public static ISumadora fabri (int identificador)
        {
            if(identificador == 1)
            {
                return new CSuma();
            }

            else if(identificador == 2)
            {
                return new CResta();
            }

            else if (identificador == 3)
            {
                return new CMultiplicacion();
            }
            else if (identificador == 4)
            {
                return new CDivision();
            }
            else
            {              
               return null;
            }
        }
    }
}
