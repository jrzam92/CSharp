using System;
using System.Globalization;

namespace InterfacesDemoNotificacionBasico
{
    public interface INotificacion {
        public string MostrarNotificacion();
        public DateTime VerFecha();
    }
    public class Notificacion : INotificacion
    {
        public Notificacion(string personaEnvia, string mensaje, DateTime fecha)
        {
            PersonaEnvia = personaEnvia;
            Mensaje = mensaje;
            Fecha = fecha;
        }
        public Notificacion()
        {
            PersonaEnvia = "Raul";
            Mensaje = "Hello World 3D !!!";
            Fecha =new DateTime();
        }
        public string PersonaEnvia  { get; set; }
        public string Mensaje { get; set; }
        public DateTime Fecha { get; set; }
        public string MostrarNotificacion()
        {
            return string.Format("El mensaje {0} fue enviado por {1} el dia {2}", Mensaje,PersonaEnvia,Fecha);
        }

        public DateTime VerFecha()
        {
            return Fecha;
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime= DateTime.Now;
            Notificacion notificacion = new Notificacion("Raul", "Hola que tal como andas", dateTime);
            Console.WriteLine(notificacion.MostrarNotificacion());
            notificacion = new Notificacion("Daniel", "Que pedo", dateTime);
            Console.WriteLine(notificacion.MostrarNotificacion());
            Console.Read();
        }
    }
}
