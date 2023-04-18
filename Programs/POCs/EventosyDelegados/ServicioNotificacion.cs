using System;

namespace EventosyDelegados
{
    public class ServicioNotificacion {
        public void EnArchivoDescargado(object fuente, ArchivoEventArgs e)
        {
            Console.WriteLine("Informamos que el file {0} a terminado de descargarse!!!",e.Archivo.Titulo);
        }
    }
}
