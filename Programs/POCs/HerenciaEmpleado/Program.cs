using System;

namespace HerenciaEmpleado
{
    public class Program
    {
        static void Main(string[] args)
        {
          
            Empleado Raul= new Empleado("Raul","Zamora",21000);
            Console.WriteLine(Raul.Trabajar());
            Console.WriteLine(Raul.Descansar());
            Jefe Jose = new Jefe("Audi Rojo Convertible", "Jose", "Villaseñor", 65000);
            Console.WriteLine(Jose.Dirigir());

            Pasante Junior = new Pasante("ESDIE", 5, 6, "Junior", "ZamVill", 4000);
           
            Console.WriteLine(Junior.Aprender());
            Console.WriteLine(Junior.Trabajar());
            Console.Read();
        }
    }
}
