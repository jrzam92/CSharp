using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventosyDelegados
{
    public class ArchivoEventArgs : EventArgs {
        public Archivo Archivo { get; set; }
    }
    public  class AsistenteDescarga
    {
    //Paso 1 Crear el delegado 
    public delegate void GestorEventDownloadFile(object fuente, ArchivoEventArgs args);

        //paso 2 crear el evento basado en el delegado 

        /// <summary>
        ///Forma de hacerse manual 
        /// public event GestorEventDownloadFile DownloadFile;
        /// </summary>
        /// <param name="archivo"></param>
       public event EventHandler<ArchivoEventArgs> DownloadFile;
        //paso 3 iniciar el evento 
        protected virtual void InDownloadedFile(Archivo archivo) { 
            if(DownloadFile!= null)
            {
                DownloadFile(this, new ArchivoEventArgs(){
                    Archivo = archivo
                });
            }
        }
        public void Descarga(Archivo archivo) {
            Console.WriteLine("Downloading file ...");
            Thread.Sleep(4000);
            InDownloadedFile(archivo);
        }
    }
}
