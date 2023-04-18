using System;

namespace OperadorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir=false;
            do { 
            Console.WriteLine("Escribe la temperatura actual del agua puede ser negativa o positiva ... ejemplo -5 o 5 :  ");
            int temperatura = int.Parse(Console.ReadLine());
            string estadoAgua=temperatura>99?"gaseoso":temperatura<0?"solido":"liquido";
                Console.WriteLine("La temperatura del agua que agregaste fue {0} por lo que el estado del agua es: {1} ",temperatura,estadoAgua);
                Console.WriteLine("Deseas continuar agregando temperaturas? si o cualquier tecla para salir  ");
                switch (Console.ReadLine()) {
                    case "si":
                        salir=true;
                        break;
                    default:
                        salir=false;
                        break;
                }
            } while (salir);

        }
    }
}
