using System;

namespace ClaseRandom
{
    public struct DetailsGame
    {
        public DetailsGame(string nameGame, string nameDeveloper, string descriptionGame)
        {
            NameGame = nameGame;
            NameDeveloper = nameDeveloper;
            DescriptionGame = descriptionGame;
        }

        public string NameGame { get; set; }
        public string NameDeveloper { get; set; }

        public string DescriptionGame { get; set; }

        public string MostrarDetalles() {
            return string.Format("\t+Nombre juego: {0}\n+Nombre desarrollador: {1}\n+Breve descripcion juego: {2}", NameGame, NameDeveloper, DescriptionGame); ;
        }

    }
    public enum Character { Mario,Zelda,Luigi,Donkey_Kong,Bowser,Sonic }
   
    public  class Program
    { 
        static void Main(string[] args)
        {
            DetailsGame detailsGame=new DetailsGame("Cartas Smash","Nintendo(JrZ)","Juego de cartas aleatorio con personajes de Smash Ultimate");
            Console.WriteLine("====================");
            Console.WriteLine(detailsGame.MostrarDetalles()); 
            Console.WriteLine("====================");
            PlayDado();
            Console.WriteLine("====================");
            Console.Read();
        }

        public static void PlayDado() {
            int numCara;
            Random dado= new Random();
            for (int i = 0; i < 11; i++)
            {
                numCara = dado.Next(0, 7);
                switch (numCara) {

                    case 1:
                        Console.WriteLine("Carta encontrada: {0}",Character.Mario);
                        break;
                    case 2:
                        Console.WriteLine("Carta encontrada: {0}", Character.Zelda);
                        break;
                    case 3:
                        Console.WriteLine("Carta encontrada: {0}", Character.Luigi);
                        break;
                    case 4:
                        Console.WriteLine("Carta encontrada: {0}", Character.Donkey_Kong.ToString().Replace("_"," "));
                        break;
                    case 5:
                        Console.WriteLine("Carta encontrada: {0}", Character.Bowser);
                        break;
                    case 6:
                        Console.WriteLine("Carta encontrada: {0}", Character.Sonic);
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
