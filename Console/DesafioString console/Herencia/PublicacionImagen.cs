using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class PublicacionImagen:Publicacion
    {
        public PublicacionImagen() { }
        public string UrlImagen{ get; set; }
        public PublicacionImagen(string titulo,string autor,string urlImagen,bool isPublico)
        {
            this.Titulo=titulo;
            this.Autor=autor;
            this.UrlImagen=urlImagen;
            this.isPublico=isPublico;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - Creado por {3}", this.Id, Titulo,UrlImagen, Autor);
        }
    }
}
