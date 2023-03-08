using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoAuto
{
    public class Auto
    {
        protected AutoInfo autoInfo = new AutoInfo();
        public Auto()
        {

        }
        public Auto(int hP, string color)
        {
            HP = hP;
            Color = color;
        }

        public int HP { get; set; }
        public string Color { get; set; }

        public string getDetalles() {
            return string.Format("HP: {0} -  Color: {1}", HP, Color);
        }
        public virtual string FixedCar()
        {
            return string.Format("El auto esta reparado");
        }

        public void setAutoInfo(int id,string propietario) { 
            autoInfo.Id= id;
            autoInfo.Propietario= propietario;
        }
        public string getAutoInfo() { 
            return string.Format("El Id del auto es {0} y su propietario es {1}", autoInfo.Id,autoInfo.Propietario);
        }

    }
}
