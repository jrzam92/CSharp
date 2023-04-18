using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    public class Caja
    {
  
        private double alto;
        private double largo;
        #region Propiedades
        public double Volumen { 
            get => Alto * Ancho * Largo; 
        }
        public string NombreCaja { get; set; }
        public double Alto { get => alto;  set => alto = value; }
        public double Ancho { get;  set; }
        public double Largo { get { return largo; } set { largo = value; } }
        #endregion
        public Caja(double largo, double alto, double ancho)
        {
            Largo = largo; 
            Alto = alto;
            Ancho = ancho; 
        }
        public Caja()
        {

        }
    }
}
