using System;

namespace OperadorTernarioTemperaturaJuego2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperaturaIngresa = 0;
            string mesajeTemperatura=string.Empty; 
            string valorIngresado=string.Empty;
            bool salir = false;
            do
            { 
            Console.WriteLine("Escribe la temperatura actual ... ");
            valorIngresado = Console.ReadLine();
            bool integerValido=int.TryParse(valorIngresado, out temperaturaIngresa);
            switch (integerValido) { 
                case true:
                    mesajeTemperatura = temperaturaIngresa <= 15 ?
                        //si es verdadero
                        "Hace mucho frio" :
                        //si es false
                        (temperaturaIngresa >= 16 && temperaturaIngresa <= 28) ?
                        //si es verdadero
                        "Hace un clima agradable" : 
                        //si es false
                        "Hace mucho calor";   
                      
                    Console.WriteLine(mesajeTemperatura);
                        Console.WriteLine("\nQuieres seguir agregando tempreaturas? /// si o toca cualquier tecla para salir... ");
                        if (Console.ReadLine() == "si")
                        {
                            salir = true;
                        }
                        else
                        {
                            salir = false;
                        }
                        break;
                default:
                    Console.WriteLine("Esa no es temperatura valida");
                        Console.WriteLine("Quieres seguir agregando tempreaturas? /// si o toca cualquier tecla para salir... ");
                        if (Console.ReadLine() == "si")
                        {
                            salir = true;
                        }
                        else {
                            salir=false;
                        }
                         
                        break;
            }
            } while (salir);
        }
    }
}
