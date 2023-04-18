using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;

namespace DelegadosDemo
{
    public class Numero {
        public int numero { get; set; }
    }
    public class Program
    {
        public delegate double HacerCalculo(double x,double y);
        public static double suma(double x, double y) {
            return x + y;
        }
        public static double division(double x, double y)
        {
            return x / y;
        }

        public static double resta(double x, double y)
        {
            return x - y;
        }
        public delegate bool isIgualNumero(int i, Numero x);
        public delegate string GetDelegateString(string texto);
        public  static string DecirHola() {
            return "Hola";
        }
        public static string getMundo(GetDelegateString getDelegateString) {
            return getDelegateString("Mundo");
        }
        static void Main(string[] args)
        {
            ///Los delegados se usan mucho en los eventos dando asi para que se haga cierta gestion 
            /// Los delegados son contratos entre el emisor y receptor 
            /// Determinan la firma de un metodo gestor de eventos en el receptor y puede contener muchos punteros de metodos 
            /// 
            HacerCalculo miSuma = suma;
            //Console.WriteLine(miSuma(5,5));

            HacerCalculo miDivison = division;
            //Console.WriteLine(miDivison(5, 5));

            HacerCalculo calculoMultiple = miSuma ;
            Console.WriteLine(calculoMultiple(5, 5));
            calculoMultiple += division;
            Console.WriteLine(calculoMultiple(5, 5));
            calculoMultiple += resta;
            Console.WriteLine(calculoMultiple(5, 5));

            GetDelegateString miDelegadoString = delegate (string nombre)
            {
                return string.Format("{0}, {1}",DecirHola(),nombre);
            };
            Console.WriteLine(miDelegadoString("Raul"));
            Console.WriteLine(getMundo(miDelegadoString));


            List<int> lista=new List<int> { 1,2,3,4,5,6,7,8,9,10,11,12};
            Console.WriteLine("Numeros pares");
            List<int> listaPares=lista.FindAll(delegate (int i) {
                return i % 2 == 0;
            });
            listaPares.ForEach(x=> Console.WriteLine(x));
            List<int> listaImpares = lista.FindAll(i=> i % 2 == 1);
            Console.WriteLine("Numeros impares");
            listaImpares.ForEach(x => Console.WriteLine(x));

            isIgualNumero comp=(num1,num2)=>num1== num2.numero;
            
            Console.WriteLine(comp(5,new Numero { numero=5}));

        }
    }
}
