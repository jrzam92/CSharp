using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Publicacion
    {
        protected static int PublicacionId { get; set; }
        protected int Id { get; set; }
        protected string  Titulo { get; set; }
        protected string Autor { get; set; }
        protected bool isPublico { get; set; }

        public Publicacion()
        {
            Id = setId();
            Titulo= "Primera Publicacion";
            isPublico= true;
            Autor= "Juan Perez"; 
        }

        public Publicacion( string titulo, string autor, bool isPublico)
        {
            Id = setId();
            Titulo = titulo;
            Autor = autor;
            this.isPublico = isPublico;
        }
        protected int setId() {
            return ++PublicacionId;
        }
        public void Editar(string titulo,bool isPublico)
        {
            Titulo = titulo;
            this.isPublico = isPublico;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1} - Creado por {2}", this.Id, Titulo, Autor);
        }
    }
}
