using System;
using System.IO;

namespace PolimorfismoLeerArchivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\\Users\\Raul\\source\\repos\\C# Ejercicios\\Console\\DesafioString console\\PolimorfismoLeerArchivo\\leerfile.txt";
            string path2 = @"C:\\Users\\Raul\\source\\repos\\C# Ejercicios\\Console\\DesafioString console\\PolimorfismoLeerArchivo\\ultimate_smash.txt";
            //Lee todo el texto
            string texto = File.ReadAllText(path);
            Console.WriteLine("El archivo contiene el siguiente texto \n\n{0}",texto);
            //Lee toda la linea del archivo
            string[] lineas = File.ReadAllLines(path);

            foreach (var linea in lineas)
            {
                Console.WriteLine("\t"+linea);
            }
            Console.WriteLine("=================");
            Console.WriteLine("=================");
            //Sobre escribe el archivo
            string[] newLines = { "Pokemon", "Mario", "Zelda", "Link" };
            File.WriteAllLines(path, newLines);
            lineas = File.ReadAllLines(path);
            foreach (var linea in lineas)
            {
                Console.WriteLine("\t" + linea);
            }
            Console.WriteLine("=================");
            Console.WriteLine("=================");
            string[] newLines2 = { "Pikachu", "Luigi", "Fox", "Sonic" };
            File.WriteAllLines(path2, newLines2);
            lineas = File.ReadAllLines(path2);
            foreach (var linea in lineas)
            {
                Console.WriteLine("\t" + linea);
            }
            Console.WriteLine("=================");
            Console.WriteLine("=================");
            //Se hace una sobre escritura y queda solo lo que se le manda 
            using (StreamWriter archivo = new StreamWriter(path2))
            {

                Console.WriteLine("Favor de agregar un personaje al archivo: ");
                string newCharacter = Console.ReadLine();

                archivo.WriteLine(newCharacter);

            }
            //Realizando una escritura en el archivo aqui si se queda el escrito y lo anterior 
            using (StreamWriter archivo = new StreamWriter(path2,true)) {

                Console.WriteLine("Favor de agregar un personaje al archivo: ");
                string newCharacter=Console.ReadLine();
              
                archivo.WriteLine(newCharacter);

            }
            Console.WriteLine("=================");
            Console.WriteLine("=================");
            string path3 = @"C:\\Users\\Raul\\source\\repos\\C# Ejercicios\\Console\\DesafioString console\\PolimorfismoLeerArchivo\\default.txt";
            //Es un programa para hacer el cambio de nombre y agregar texto lineal
            Console.WriteLine("Favor de ingresar el nombre de tu archivo: ...(No es necesario agregarle extension!!!)");
            string fileName=Console.ReadLine();
            Console.WriteLine("Favor de ingresar el contenido del archivo:");
            string fileContent=Console.ReadLine(); 
            File.WriteAllText(path3.Replace("default",fileName), fileContent);
            Console.WriteLine("=================");
            Console.WriteLine("=================");

            Console.ReadKey();
        }
    }
}
