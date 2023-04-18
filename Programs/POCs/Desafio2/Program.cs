using System;

namespace Desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Porfavor ingresa un texto: ");
            //string ingreso=Console.ReadLine();
            //Console.WriteLine("Ingrese el caracter que quiere buscar en el texto: ");
            //char ingresoBuscado = Console.ReadLine()[0];
            //int buscarIndice=ingreso.IndexOf(ingresoBuscado);
            //Console.WriteLine(string.Format("El indice del caracter {0} en el texto {1} es  {2}", ingresoBuscado,ingreso, buscarIndice));
            //Console.ReadKey();

            Console.WriteLine("Porfavor ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Porfavor  ingrese su apellido: ");
            string apellido=Console.ReadLine();
            string nombreCompleto=string.Concat(nombre," ", apellido);
            Console.WriteLine("El nombre completo es {0}",nombreCompleto);
            Console.ReadKey();
        }
    }
}
