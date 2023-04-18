using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class Suma : INotifyPropertyChanged
    {
        private string num1;
        private string num2;
        private string resultado;

        public string Num1 {
            get{
                return num1;
            }
            set {
                int numero;
                bool res = int.TryParse(value, out numero);
                if (res) num1 = value;
                //Cambiar la proiedad si la variable a cambiado 
                OnPropertyChanged("Num1");
                OnPropertyChanged("Resultado");
            } 
        }
        public string Num2
        {
            get
            {
                return num2;
            }
            set
            {
                int numero;
                bool res = int.TryParse(value, out numero);
                if (res) num2 = value;
                //Cambiar la proiedad si la variable a cambiado 
                OnPropertyChanged("Num2");
                OnPropertyChanged("Resultado");
            }
        }

        public string Resultado {
            get
            {
                int res = int.Parse(Num1) + int.Parse(Num2);
                return res.ToString();
            }
            set {
                int res = int.Parse(Num1) + int.Parse(Num2);
                resultado = res.ToString();
                OnPropertyChanged("Resultado");
            } 
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        /// <summary>
        /// Metodo que hace el cambio de la proiedad de la variable  
        /// </summary>
        /// <param name="propiedad"></param>
        private void OnPropertyChanged(string propiedad) {

            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }
    }
}
