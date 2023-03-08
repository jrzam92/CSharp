using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEmpleado
{
    public  class Jefe:Empleado
    {
        public string  AutoEmpesa { get; set; }
        public Jefe(string autoEmpesa,string nombre,string apellido,int salario):base(nombre,apellido,salario) 
        {
            AutoEmpesa = autoEmpesa;
        }
        public string Dirigir() {
            return string.Format("Hola, Que tal ... soy {0} {1}.\nEstoy liderando mi empresa y gano {2} euros.\n manejo un carro : {3}",Nombre,Apellido,Salario,AutoEmpesa);
        }
    }
}
