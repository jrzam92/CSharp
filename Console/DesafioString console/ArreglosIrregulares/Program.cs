using System;

namespace ArreglosIrregulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[][] irregular = new int[3][];
            //irregular[0]=new int[5];
            //irregular[1] = new int[3];
            //irregular[2] = new int[2];

            //irregular[0] =new int[]{ 2,3,8,9,11};
            //irregular[1] = new int[] { 23,100,15 };
            //irregular[2] = new int[] { 5,900 };

            //int[][] irregular2 = new int[][] {
            //new int[]{ 2,3,8,9,11},
            // new int[] { 23,100,15},
            // new int[] { 5,900 }
            //};

            //for (int i = 0; i < irregular2.Length; i++)
            //{
            //    Console.WriteLine("Los valores del arreglo {0} son: ",i);
            //    for (int j = 0; j < irregular2[i].Length; j++)
            //    {
            //        Console.WriteLine("\t+ {0}", irregular2[i][j]);
            //    }
            //}

            string[][] pokemones = new string[][] { 
                new string[]{"Pikachu","Charmander","Onix"},
                new string[]{"Charizard", "Bulbasaur", "Nidoran", "Meowth"},
                new string[]{ "Vulpix", "Zubat","Rhyhorn"},
                new string[]{ "Psyduck", "Squirtle", "Abra"},
                new string[]{ "Machop", "Geodude","Cubone"},
                new string[]{ "Gastly", "Grimer", "Haunter","Gengar"}
            };
            for (int i = 0; i < pokemones.Length; i++)
            {
                Console.WriteLine(" Los pokemones del jugador {0} son: ", i);
                for (int j = 0; j < pokemones[i].Length; j++)
                {
                    Console.WriteLine("\t+ {0}", pokemones[i][j]);
                }
            }

            Console.WriteLine(" {0} peleara con {1}", pokemones[0][0], pokemones[3][2]);
            Console.WriteLine(" {0} peleara con {1}", pokemones[1][1], pokemones[5][3]);
            Console.WriteLine(" {0} peleara con {1}", pokemones[2][1], pokemones[4][2]);
            Console.WriteLine(" {0} peleara con {1}", pokemones[3][1], pokemones[3][1]);
            Console.WriteLine(" {0} peleara con {1}", pokemones[4][1], pokemones[2][0]);
            Console.WriteLine(" {0} peleara con {1}", pokemones[5][1], pokemones[1][2]);
            Console.WriteLine(" {0} peleara con {1}", pokemones[1][3], pokemones[0][2]);
            Console.Read();
        }
    }
}
