using System;

namespace PiedraPapelTijera
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            
                    chooseOption();
                    Console.ReadKey();
          
            
        }
        public static void chooseOption() {
            bool game=false;
            do
            {

                Console.WriteLine("Escoge entre piedra - papel - tijera .... escribe cualquier teacla para salir del juego");
                string choose=Console.ReadLine().ToLower().Trim();
                switch (choose) {
                    case "piedra":
                        Console.WriteLine("piedra gana a tijera");
                        game = true;
                        break;
                    case "papel":
                        Console.WriteLine("papel gana a piedra");
                        break;
                    case "tijera":
                        Console.WriteLine("tijera gana a papel");
                        game = true;
                        break;
                    default:
                        Console.WriteLine("Gracias por jugar game over!!!...");
                        game = false;
                        break;
                }
            }while (game);
         
        }
    }
}
