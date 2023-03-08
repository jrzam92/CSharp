using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosyDelegados
{
    public class ServicioDesempacar
    {
        public void EnArchivoDescargado(object fuente, ArchivoEventArgs e) {
            Console.WriteLine("Servicio desempacar: desempacando file ...{0}", e.Archivo.Titulo);
        }
    }
}
