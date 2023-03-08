using System;
using System.Linq;
using System.Xml.Linq;

namespace LinConXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aplicaciones la estructura de Estudiante a XML 

            string estudiantesXML =
                @"<Estudiantes>
                    <Estudiante>
                        <Nombre>Raul</Nombre>
                        <Edad>30</Edad>
                        <Universidad>ESDIE</Universidad>
                        <Materias>17</Materias>
                    </Estudiante>
                        <Estudiante>
                        <Nombre>Jaime</Nombre>
                        <Edad>29</Edad>
                        <Universidad>ESDIE</Universidad>
                        <Materias>11</Materias>
                    </Estudiante>
                        <Estudiante>
                        <Nombre>Edgar</Nombre>
                        <Edad>35</Edad>
                        <Universidad>ESDIE</Universidad>
                        <Materias>28</Materias>
                    </Estudiante>
                    <Estudiante>
                        <Nombre>Carlos</Nombre>
                        <Edad>28</Edad>
                        <Universidad>ESDIE</Universidad>
                        <Materias>28</Materias>
                    </Estudiante>
                </Estudiantes>";

            XDocument estudianteXdoc=new XDocument();
            estudianteXdoc=XDocument.Parse(estudiantesXML);

            //Se esatara buscando bajo el nodo de Estudiante
            Console.WriteLine("==========================");
            Console.WriteLine("==========================");
            Console.WriteLine("Listado de alumnos");
            var estudiantes = from estudiante in estudianteXdoc.Descendants("Estudiante")
                              select new
                              {
                                  Nombre = estudiante.Element("Nombre").Value,
                                  Edad = estudiante.Element("Edad").Value,
                                  Universidad = estudiante.Element("Universidad").Value,
                                  Materias=estudiante.Element("Materias").Value
                              };
            foreach(var alumno in estudiantes)
            {
                Console.WriteLine("\tEl estudiante {0} tiene {1} años y asiste a la universidad {2} con {3} materias aprobadas. ", alumno.Nombre,alumno.Edad,alumno.Universidad,alumno.Materias);
            }
            Console.WriteLine("==========================");
            Console.WriteLine("==========================");
            Console.WriteLine("Ordenamiento de estudiantes por edad");
            //Nueva busqueda para ordener a los estudiantes por edad...
            var estudiantesOrdenados = from alumno in estudiantes
                                       orderby alumno.Edad
                                       select alumno;

            foreach (var alumno in estudiantesOrdenados)
            {
                Console.WriteLine("\tEl estudiante {0} tiene {1} años y asiste a la universidad {2}", alumno.Nombre, alumno.Edad, alumno.Universidad);
            }
            Console.ReadKey();
        }
    }
}
