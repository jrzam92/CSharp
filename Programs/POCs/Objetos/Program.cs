using System;

namespace Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Creacion de avatares da \"Enter\" para continuar");
            while (Console.ReadLine().ToLower() != "salir") {
                Console.WriteLine("Para dejar de crear avatares escribe \"salir\"");
                new Humano();
                Console.WriteLine("Da enter para continuar o bien si deseas cancelar el programa escribe \"salir\"");
               
            }
            
        }
    }
}
