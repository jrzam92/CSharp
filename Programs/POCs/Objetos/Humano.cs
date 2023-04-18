using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Humano
    {
        private string Edad ;
        private string Nombre ;
        private string Genero ;
        private string ColorPelo ;
        private string ColorOjos ;
        private string Peso ;
        private string Altura ;

        public Humano()
        {
            CreateAvatar();
        }
       
        public void CreateAvatar() {
            int edadTry = 0;
            double altura = 0d;
            double peso = 0d;
            Console.WriteLine("¿Cuál es el nombre de tú avatar? ");
            this.Nombre = Console.ReadLine();
            Console.WriteLine("¿Cuál es el edad tiene tú avatar? ");
            this.Edad = Console.ReadLine();
            edadTry = int.TryParse(this.Edad, out edadTry) ? edadTry : 0;
            if (edadTry == 0)
            {
                Console.WriteLine("¿Cual es el edad tiene tú avatar? ");
                edadTry = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("¿Cuál es el genero es tú avatar?");
            this.Genero = Console.ReadLine();
            Console.WriteLine("¿Cuál es el color de pelo tú avatar? ");
            this.ColorPelo = Console.ReadLine();
            Console.WriteLine("¿Cuál es el color de ojos tú avatar? ");
            this.ColorOjos = Console.ReadLine();
            Console.WriteLine("¿Cuál es la altura de tú avatar? ");
            this.Altura = Console.ReadLine();
            altura = double.TryParse(this.Altura, out altura) ? altura : 0;
            if (altura == 0)
            {
                Console.WriteLine("¿Cuál es el altura tiene tú avatar? ");
                altura = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("¿Cuál es el peso de tú avatar? ");
            this.Peso = Console.ReadLine();
            peso = double.TryParse(this.Peso, out peso) ? peso : 0;
            if (peso == 0)
            {
                Console.WriteLine("¿Cuál es el peso tiene tú avatar? ");
                peso = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("=====================================");
            Console.WriteLine("Informacion de Personaje:");
            Console.WriteLine("\t+Tu avatar se llama {0}\n\t+Tiene una edad de :{1}\n\t+El genero que tiene es: {2}", Nombre, edadTry,Genero);
            Console.WriteLine("\t+El color de pelo escogido es de: {0}\n\t+El color de ojos :{1}\n\t+Mide: {2} cm\n\t+Pesa: {3} Kg", ColorPelo, ColorOjos, altura,peso);
            Console.WriteLine("=====================================");
        }
    }
}
