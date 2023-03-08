using System;

namespace DesafioString_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string miNombre;
            Console.WriteLine("Porfavor ingresa tu  nombre:");
            miNombre=Console.ReadLine();
            string miNombreMayuscula = string.Format("En mayusculas es {0}", miNombre.ToUpper());
            string miNombreMinuscula = string.Format("En minuscula es {0}", miNombre.ToLower());
            string miNombreSinEspacios = string.Format("Sin espacios es {0}", miNombre.Trim());
            string miNombreSubstring = string.Format("Valor del substring es {0}", miNombre.Substring(0,5));
            Console.WriteLine(miNombreMayuscula);
            Console.WriteLine(miNombreMinuscula );
            Console.WriteLine(miNombreSinEspacios );
            Console.WriteLine(miNombreSubstring);
            Console.ReadKey();




        }
    }
}
