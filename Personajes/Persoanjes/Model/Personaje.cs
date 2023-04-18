using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandorasCharacter.Model
{
    public class Personaje
    {
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Estatura { get; set; }
        public string Peso { get; set; }
        public string Sexo { get; set; }
        public string Contextura { get; set; }
        public string ColorOjos { get; set; }
        public string ColorCabello { get; set; }
        public string ColorPiel { get; set; }
        public string Raza { get; set; }
        public string DescripcionGeneral { get; set; }

        public int Health { get; set; } = 100;
        public int Power { get; set; } = 0;
        public int Energy { get; set; } = 0;
        public List<string> Atributos { get; set; }

    }
}
