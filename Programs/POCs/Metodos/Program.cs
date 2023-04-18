using System;
using System.Collections.Generic;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Metodo void
            //EscribeAlgo();
            ////Metodo void con parametro
            //EscribeAlgoEspecifico("Parametro desde MAIN");
            ////Metodos con retorno int y double y con parametros 
            //Console.WriteLine("Resultado de Suma ->"+Sumar(15, 31));
            //Console.WriteLine("Resultado de Multiplicar->" + Multiplicar(15, 31));
            //Console.WriteLine("Resultado de Dividir->" + Dividir(15, 31));
            //SaludoAmigo("Daniel", "Erick", "Marcos");
            Calcular();
            Console.Read();
        }
        //Nivel de acceso (static) - Tipo de retorno - Nombre del metodo - (Parametro1,Parametro 2)
        public static void EscribeAlgo() {
            Console.WriteLine("Yo naci en un metodo"); 
        }
        public static void EscribeAlgoEspecifico(string miParametro)
        {
            Console.WriteLine(miParametro); 
        }

        public static int Sumar(int num1, int num2) { 
        
            return num1 + num2;
        }
        public static int Multiplicar(int num1, int num2)
        {

            return num1 * num2;
        }
        public static double Dividir(double num1, double num2)
        {

            return num1 / num2;
        }

        public static void SaludoAmigo(string amigo1, string amigo2, string amigo3) { 
        List<string> amigos=new List<string>();
            amigos.Add(amigo1);
            amigos.Add(amigo2);
            amigos.Add(amigo3);
            amigos.ForEach(x => { 
            Console.WriteLine("¡Hola amigo "+x+"! espero que te encuentres bien...");
            });
        }
        public static void Calcular() {

            Console.WriteLine("Por favor, ingrese un numero: ");
            string numero1Input=Console.ReadLine();
            Console.WriteLine("Por favor, ingrese un otro numero: ");
            string numero2Input = Console.ReadLine();

            int num1=int.Parse(numero1Input);
            int num2=int.Parse(numero2Input);

            int resultado = num1 + num2;
            Console.WriteLine("La suma de los numeros \"{0}\" y \"{1}\" dan como resultado: \"{2}\"", num1,num2,resultado); 
        }
    }
}
