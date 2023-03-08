using System;

namespace Fechas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El dia de hoy es {0}, el dia correspondiente es {0}",DateTime.Now,DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.AddDays(1));
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Today.AddDays(1));

            int anio = 2000;
            string febrero = "Febrero";
            int dias = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine("El mes de {0} de {1}, tuvo {2} dias",febrero,anio,dias);
            dias = DateTime.DaysInMonth(2001, 2);
            Console.WriteLine("El mes de {0} de {1}, tuvo {2} dias", febrero, anio, dias);
            dias = DateTime.DaysInMonth(2004, 2);
            Console.WriteLine("El mes de {0} de {1}, tuvo {2} dias", febrero, anio, dias);

            DateTime ahora=DateTime.Now;
            Console.WriteLine("Minuto {0}",ahora.Minute);

            Console.WriteLine("En este momento son las {0} horas, con {1} minutos y {2} segundos",ahora.Hour,ahora.Minute,ahora.Second);

            DateTime tiempo = new DateTime(2022, 12, 09);
            Console.WriteLine("El tiempo es: {0}",tiempo);

            Console.WriteLine("Favor de ingresar una fecha de nacimiento: aaaa-mm-dd");
            string ingreso = Console.ReadLine();
            if (DateTime.TryParse(ingreso, out tiempo))
            {
                Console.WriteLine("La fecha introducida fue: {0}", tiempo);
                TimeSpan diasEnteros = ahora.Subtract(tiempo);
                Console.WriteLine(" {0}, son los dias que has estado en el planeta Tierra", diasEnteros.Days);
            }
            else {
                Console.WriteLine("Ingreso incorrecto");
            }

            Console.Read();
        }
        public DateTime ProximoDia() { 
            return DateTime.Now.AddDays(1);
        }
    }
}
