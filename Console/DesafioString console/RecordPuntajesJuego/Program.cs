using System;

namespace RecordPuntajesJuego
{
    internal class Program
    {
        static int record=300;
        static string recordJugador="Luis";
        static void Main(string[] args)
        {
            NuevoRecord(301, "Richi", recordJugador);
            recordJugador = "Richi";
            NuevoRecord(302, "Joshi", recordJugador);
            recordJugador = "Joshi";
            NuevoRecord(303, "Rixi", recordJugador);
            recordJugador = "Rixi";
            NuevoRecord(304, "Sinto", recordJugador);
            Console.Read();
        }
        public  static void NuevoRecord(int puntaje, string jugador,string recordJugador) {

            if (puntaje>record) {

                record = puntaje;
                
                Console.WriteLine("El nuevo record con el puntaje {0} logrado por {1} vencio a {2}", record, jugador, recordJugador);
            }
            else {
                Console.WriteLine("El  record vigente de {0} logrado por {1} no ha sido superado", record, recordJugador);
            }

        }

    }
}
