using System;

namespace EventosyDelegados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var archivo = new Archivo() { Titulo = "Archivo 1" };
            var asistenteDescarga = new AsistenteDescarga();//emisor
            var servicioDesempacar=new ServicioDesempacar();//receptor
            var servicioNotificacion = new ServicioNotificacion();//receptor
            asistenteDescarga.DownloadFile += servicioDesempacar.EnArchivoDescargado;
            asistenteDescarga.DownloadFile += servicioNotificacion.EnArchivoDescargado;
            asistenteDescarga.Descarga(archivo);
            Console.Read();
        }
    }
}
