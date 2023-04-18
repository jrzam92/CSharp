using System;

namespace CondicionesIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
                AgregaTemperatura();
            }
            Console.ReadKey();
        }
        public static void AgregaTemperatura() {

            Console.WriteLine("Proporcioname la temperatura actual: ");
            string getTemperatura = Console.ReadLine();
            int temperatura;
            //Posible forma de cachar un error sin el trycatch
            int numeroTemp;
            if (!int.TryParse(getTemperatura, out numeroTemp))
            {
                numeroTemp = 0;
                temperatura = numeroTemp;
                Console.WriteLine("El valor ingresado no es valido, se establece que la temperatura es: {0} ", numeroTemp);
            }
            else {
                temperatura = numeroTemp;
            }
         

            if (temperatura < 20) {
                Console.WriteLine("Abrigate que hace frio ");
            }
            else if (temperatura == 20)
            {
                Console.WriteLine("Abrigate que hace frio ");
            }
            else if (temperatura > 30)
            {
                Console.WriteLine("Hace mucho calor! vete a la playa ");
            }
            else 
            {
                Console.WriteLine("Hace calor por lo que puedes usar ropa ligera");
            }
        }
    }
}
