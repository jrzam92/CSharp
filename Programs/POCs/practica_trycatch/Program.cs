using System;

namespace practica_trycatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            divide();
            Console.ReadKey();
        }
        public static void divide() {
            try
            {
                Console.WriteLine("Ejercicio de division de numeros: ");
                Console.WriteLine("Proporcioname un numero: ");
                int numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Proporcioname otro numero: ");
                int numero2 = int.Parse(Console.ReadLine());
                int resultado = numero1 / numero2;
                Console.WriteLine("La division del numero 1 que agregaste  {0} / con el numero 2 {1} tiene como resultado: {2} ", numero1, numero2, resultado);

            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No se escribio el numero");
            }
            catch (FormatException)
            {
                Console.WriteLine("El formato no es valido para el numero");
            }
            catch (OverflowException)
            {
                Console.WriteLine("El numero que se ingreso es demasiado largo o corto ");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir un numero entero sobre cero ...");
            }
            

        }
    }
}
