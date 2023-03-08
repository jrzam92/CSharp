using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEmpleado
{
    public class Empleado
    {
        public Empleado()
        {

        }
        /// <summary>
        /// Constructor de empleado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="salario"></param>
        public Empleado(string nombre, string apellido, int salario)
        {
            Nombre = nombre;
            Apellido = apellido;
            Salario = salario;
        }
        /// <summary>
        /// Variables de Empleado
        /// </summary>
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Salario { get; set; }

        public string Trabajar() {
            return "Estoy trabajando";
        }
        public string Descansar() {
            return "Estoy descansando";
        }


    }
}
