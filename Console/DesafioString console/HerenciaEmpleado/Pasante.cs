using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEmpleado
{
    public  class Pasante:Empleado
    {
        public int  HorasTrabajo { get; set; }
        public int HorasEscuerla { get; set; }
        public string Escuela { get; set; }

        public Pasante(string escuela,int horasTrabajo, int horasEscuela, string nombre, string apellido, int salario):base(nombre,apellido,salario)
        {
            HorasTrabajo = horasTrabajo;
            HorasEscuerla = horasEscuela;
            Escuela = escuela;
        }

        public string Aprender() {
            return string.Format("Hola soy {0} {1} y estoy en la escuela {2} aproximadamente {3} horas",Nombre,Apellido,Escuela,HorasEscuerla);
        }
        public string Trabajar()
        {
            return string.Format("Hola soy {0} {1} y la jornada  de trabajo es de: {2} horas, ganando un salario de: {3}",Nombre,Apellido,HorasTrabajo,Salario);
        }
    }
}
