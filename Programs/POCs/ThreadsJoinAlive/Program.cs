using System;
using System.Threading;

namespace ThreadsJoinAlive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main ha comenzado!!!");
            Thread hilo1 = new Thread(FuncionThread1);
            Thread hilo2 = new Thread(FuncionThread2);
            hilo1.Start();
            hilo2.Start();

            //hilo1.Join();
            //Console.WriteLine("Funcionalidad 1 esta listo");
           

            if (hilo1.Join(1000))
            {
                Console.WriteLine("Funcionalidad 1 terminada");
            }
            else {
                Console.WriteLine("Funcionalidad 1 no termino en un segundo");
            }
            hilo2.Join();
            Console.WriteLine("Funcionalidad 2 esta listo");

            for (int i = 0; i < 10; i++)
            {
                if (hilo1.IsAlive)
                {
                    Console.WriteLine("Hilo 1 sigue haciendo cosas");
                    Thread.Sleep(300);
                }
                else {
                    Console.WriteLine("hilo 1 termino con lo suyo");
                } 
            }



            Console.WriteLine("Main ha Finalizado!!!");
        }

        public static void FuncionThread1(){
            Console.WriteLine("inicio de funcionalidad 1");
            Thread.Sleep(3000);
            Console.WriteLine("funcion thread 1 regresa al main");
        }
        public static void FuncionThread2(){
            Console.WriteLine("inicio de funcionalidad 2");
        }
    }
}
