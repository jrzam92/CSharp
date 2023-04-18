using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoAuto
{
    public  class Audi:Auto
    {
        public string Marca = "Audi";
        public string Modelo { get; set; }
        public Audi(int hp,string color, string modelo) : base(hp, color)
        {
            Modelo = modelo;
        }
        public new string getDetalles() {
            return string.Format("Marca: {0} - Modelo {1} tiene un HP: {2} -  Color: {3}", Marca,Modelo,HP, Color);
        }
        public override string FixedCar() {
            return string.Format("El auto de la marca {0} con modelo {1} de color {2} esta reparado",Marca,Modelo,Color);
        }
    }
}
