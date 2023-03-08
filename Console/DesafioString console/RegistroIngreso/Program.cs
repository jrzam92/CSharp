using System;

namespace RegistroIngreso
{
    internal class Program
    {
        static string nombreUsuario;
        static string clave;
        static void Main(string[] args)
        {
            Registro();
            Ingreso();
            Console.ReadKey(); 
        }
        public static void Registro() {
            Console.WriteLine("Por favor ingrese su nombre de usuario:");
            nombreUsuario = Console.ReadLine();
            Console.WriteLine("Favor de ingresar su clave:");
            clave = Console.ReadLine();
            Console.WriteLine("Registro exitoso!!!");
            Console.WriteLine("-----------------------");
        }
        public static void Ingreso() { 
            Console.WriteLine("Favor de ingresar su nombre de usuario:");
            if (nombreUsuario == Console.ReadLine())
            {
                Console.WriteLine("Favor de ingresar su clave:");
                if (clave == Console.ReadLine()) { 
                
                    Console.WriteLine("Ingreso exitoso!!!");
                }
                else
                {
                    Console.WriteLine("Clave incorrecta,  favor de reiniciar el sistema...");
                }
            }
            else {
                Console.WriteLine("Usuario incorrecto,  favor de reiniciar el sistema...");
            }
        }
    }
}
