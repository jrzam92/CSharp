using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Herencia
{
    public class PublicacionVideo:Publicacion
    {

        protected bool SetPlay { get; set; }
        protected int DuracionActual = 0;
        Timer timer;

        public int Duracion { get; set; }
        public string UrlVideo { get; set; }
        public PublicacionVideo()
        {

        }
        public PublicacionVideo(string titulo,string autor, string urlVideo, bool isPublico, int duracion) 
        {
            this.Id = setId();
            Autor = autor;
            UrlVideo = urlVideo;
            this.isPublico = isPublico;
            this.Duracion = duracion;
            this.UrlVideo= urlVideo;
        }
        public override string ToString()
        {
            return string.Format("Titulo:{0} \n\t-Creado por:{1}\n\t-Duración Animacion:{2} segundos\n\t-Es publica:{3}\n\t-Video:{4}", Titulo, Autor, Duracion, isPublico ? "Si es publico" : "El video es privado", UrlVideo);
        }
        public void Play() {
            if (!SetPlay) {
                SetPlay=true; 
            timer = new Timer(Reproduccion, null, 0, 1000);
            }
        }

        private void Reproduccion(object state)
        {
            if (DuracionActual < Duracion)
            {
                DuracionActual++;
                Console.WriteLine("\t*Video en {0}s", DuracionActual);
                GC.Collect();
            }
            else { 
             Stop();
            }
        }

        public void Stop() {
            if(SetPlay)
            {
                SetPlay=false;

                Console.WriteLine("Video detenido en {0}s", DuracionActual);
                DuracionActual = 0;
                timer.Dispose();
            }
        }

    }
}
