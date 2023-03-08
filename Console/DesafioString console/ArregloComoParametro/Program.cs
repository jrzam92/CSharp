using System;

namespace ArregloComoParametro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] calificaciones = {8,9,7,8,9,6,10};
            //double promedio=getPromedioAlumnos(calificaciones);
            //Console.WriteLine("Las notas del alumno son:");
            //foreach (var nota in calificaciones)
            //{
            //    Console.WriteLine(nota);
            //}
            //Console.WriteLine("El alumno obtiene como promedio: {0}", promedio);

             
            int[] becas = { 1000, 1200, 1400, 1500, 1600 };
            Console.WriteLine("\n===============================");
            Console.WriteLine("=============BECA SIN AUMENTO==================");
            foreach (var beca in becas)
            {



                Console.WriteLine("Las becas son:{0}", beca);

            }
            Console.WriteLine("===============================");
            setAumentoBeca(becas);
            Console.WriteLine("\n===============================");
            Console.WriteLine("=============BECA CON AUMENTO==================");
            foreach (var beca in becas)
            {
               
                
                
                Console.WriteLine("Las becas son:{0}", beca);
               
            }
            Console.WriteLine("===============================");
        }
        public static void setAumentoBeca(int[] saldo) {
            for (int i = 0; i < saldo.Length; i++)
            {
                saldo[i] += 200;
            }
        }
        public static double getPromedioAlumnos(int[] notas) {

            double promedio=0d;
            int total = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                total += notas[i];
                promedio = total / notas.Length;
            }

            return promedio;
        
        }
    }
}
