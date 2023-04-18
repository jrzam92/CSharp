using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Impares(numeros);
            Pares(numeros);
            Console.ReadKey();
        }

        public static void Impares(int[] numeros) {
            Console.WriteLine("Numeros impares");

            IEnumerable<int> numerosImpares = from numero in numeros where numero % 2 != 0 select numero;

            Console.WriteLine(numerosImpares.Count());

            Console.WriteLine("Los numeros impares son:");
            foreach (var item in numerosImpares)
            {
                Console.WriteLine(item);
            }
        }
        public static void Pares(int[] numeros)
        {
            Console.WriteLine("Numeros pares");

            IEnumerable<int> numerosPares = from numero in numeros where numero % 2 != 1 select numero;

            Console.WriteLine(numerosPares.Count());

            Console.WriteLine("Los numeros pares son:");
            foreach (var item in numerosPares)
            {
                Console.WriteLine(item);
            }
        }
    }
}
