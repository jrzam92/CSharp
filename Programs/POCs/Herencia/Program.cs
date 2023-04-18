using System;

namespace Herencia
{
    internal class Program
    {
        /// <summary>
        /// Herencia 
        /// Nos permite definir una clase en funcion de otra clase. Esto para crear y mantener una aplicacion 
        /// Dando asi la oportunidad de reutilizar la funcionalidad del codigo y acelerar el tiempo de implementacion 
        /// ejemplo:
        /// Carro base
        ///     +++Propiedades
        ///         carro de carreras 
        ///         carro de ciudad
        ///     
        ///             --propiedades 
        ///             
        /// Empleado
        ///     propiedades 
        ///         Salario 
        ///         Horas
        ///    Diseñador
        ///         dibuja
        ///    Desarrollador
        ///         desarrolla
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Publicacion post1= new Publicacion("Saludos esta es una publicacion","Raul",true);
            Console.WriteLine(post1.ToString());
            PublicacionImagen ima1 = new PublicacionImagen("Post con imagen", "Raul", "https://imagen/oso.png", true);
            Console.WriteLine(ima1.ToString());
            PublicacionVideo video1 = new PublicacionVideo("Animacion de oso", "Raul", "\"https://video/oso.avi", false, 10);
            Console.WriteLine(video1.ToString());
            Console.WriteLine("Presione cualquier tecla para detener el video");
            Console.WriteLine(">Reproduciendo ...");
            video1.Play();
            Console.ReadKey();
            video1.Stop();

            Console.Read();
        }
    }
}
