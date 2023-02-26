using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Modulo_3
{
    internal class CPersonas
    {
        private string nombre;

        private string apellido;

        private string fechaNacimiento;

        private string provincia;


        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Provincia { get => provincia; set => provincia = value; }
    }
}
