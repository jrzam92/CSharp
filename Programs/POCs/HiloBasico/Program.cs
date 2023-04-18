using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HiloBasico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Revisar cuando este en depuracion en la barra de Depurar la ventana de subprocesos  ctrl + D
            //Console.WriteLine("Hola  mundo 1");
            //Thread.Sleep(1000);//Esta funcion lo que realiza es esperar en el proceso por un segundo 
            //Console.WriteLine("Hola  mundo 2");
            //Thread.Sleep(1000);

            //Console.WriteLine("Hola  mundo 3");
            //Thread.Sleep(1000);

            //Console.WriteLine("Hola  mundo 4");
            //Thread.Sleep(1000);

            //Console.WriteLine("Hola  mundo 5");

            ///Los hilos pueden tener diferentes subprocesos por lo que en consola no necesariamente el primer subproceso debe de entrar primero 
            //new Thread(() =>
            //{
            //    Thread.Sleep(1000); 
            //    Console.WriteLine("Subproceso 1");
            //}
            //).Start();
            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Subproceso 2");
            //}
            //).Start();
            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Subproceso 3");
            //}
            //).Start();
            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Subproceso 4");
            //}
            //).Start();

            //Console.ReadKey();


            /////Siguiente ejemplo de threads
            ///========
            ///
            // var tareaCompleta = new TaskCompletionSource<bool>();
            // var hilo = new Thread(() =>
            // {
            // Console.WriteLine($"Numero de subproceso {Thread.CurrentThread.ManagedThreadId} ha iniciado");
            //     Thread.Sleep(1000);
            //     tareaCompleta.TrySetResult(true);
            //     Console.WriteLine($"Numero de subproceso {Thread.CurrentThread.ManagedThreadId} ha terminado");

            // });
            //hilo.Start();
            // var prueba=tareaCompleta.Task.Result;

            // Console.WriteLine("La prueba fue: {0}",prueba==true?"Exitosa":"Fallida");
            // Console.ReadLine();
            // Console.ReadKey();

            /////Siguiente ejemplo de threads en una lista
            /// hay que tener cuidado con los hilos al solo ponerlos asi .... 
            ///========
            ///
            //Enumerable.Range(0,20).ToList().ForEach(x =>
            //{
            //    new Thread(() =>
            //    {
            //        Console.WriteLine($"Numero de subproceso {Thread.CurrentThread.ManagedThreadId} ha iniciado");
            //        Thread.Sleep(1000);
            //        Console.WriteLine($"Numero de subproceso {Thread.CurrentThread.ManagedThreadId} ha terminado");

            //    }).Start();
            //}
            //);
            /////Siguiente ejemplo de threads en una lista
            /// Manera correcta de manejar los threads en una lista
            ///========
            ///
            Enumerable.Range(0, 20).ToList().ForEach(x =>
            {
                new Thread(() =>
                {
                    ThreadPool.QueueUserWorkItem((o) =>
                    {
                        Console.WriteLine($"Numero de subproceso {Thread.CurrentThread.ManagedThreadId} ha iniciado");
                        Thread.Sleep(2000);
                        Console.WriteLine($"Numero de subproceso {Thread.CurrentThread.ManagedThreadId} ha terminado");
                    });
                    

                }).Start();
            }
            );
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
