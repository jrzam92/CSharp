using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestionUniversidad gestionUniversidad = new GestionUniversidad();
            gestionUniversidad.GetGenereMan();
            Console.WriteLine("=================================");
            Console.WriteLine("=================================");
            gestionUniversidad.GetGenereWoman();
            Console.WriteLine("=================================");
            Console.WriteLine("=================================");
            gestionUniversidad.GetGenereNBinario();
            Console.WriteLine("=================================");
            Console.WriteLine("=================================");
            gestionUniversidad.OrdenarEstudiantesEdad();
            Console.WriteLine("=================================");
            Console.WriteLine("=================================");
            gestionUniversidad.MostrarUniversidadEBAC();
            //Console.WriteLine("=================================");
            //Console.WriteLine("=================================");
            //Console.WriteLine("Favor ingresa el Id de la Universidad.(1-EDIE,2-EBAC)");

            //string ingreso =Console.ReadLine();
            //try
            //{
            //    int ingresoInt = Convert.ToInt32(ingreso); 
            //    gestionUniversidad.MostrarUniversidad(ingresoInt);
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine("Valor ingresado incorrecto."); ;
            //}
            Console.WriteLine("=================================");
            Console.WriteLine("=================================");
            int[] unosInts = { 30, 12, 4, 3, 19 };
            IEnumerable<int> sortInts = from i in unosInts orderby i select i;
            IEnumerable<int> sortedIntsReverse = sortInts.Reverse();
            Console.WriteLine("Numeros ordenados descendentes (Mayor a menor)");
            foreach (int i in sortedIntsReverse) {
                Console.WriteLine(i);
            }
            IEnumerable<int> sortedIntsOtherReverse = from i in unosInts orderby i ascending select i;
            Console.WriteLine("Numeros ordenados ascendentes (Menor a mayor)");
            foreach (int i in sortedIntsOtherReverse)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("=================================");
            Console.WriteLine("=================================");
            gestionUniversidad.SetCollectionStudentUniversity();

            Console.ReadKey();
        }
    }

    class GestionUniversidad
    {
        public List<Universidad> Universidades { get; set; }
        public List<Estudiante> Estudiantes { get; set; }

        public GestionUniversidad()
        {
            Universidades = new List<Universidad>();
            Estudiantes = new List<Estudiante>();

            //Agregar universidades
            Universidades.Add(new Universidad { Id = 1, Nombre = "ESDIE" });
            Universidades.Add(new Universidad { Id = 2, Nombre = "EBAC" });

            //Agregar estudiantes
            Estudiantes.Add(new Estudiante { Id = 1, Nombre = "Raul", Genero = "Masculino", Edad = 30, UniversidadId = 1 });
            Estudiantes.Add(new Estudiante { Id = 2, Nombre = "Jose", Genero = "Masculino", Edad = 24, UniversidadId = 2 });
            Estudiantes.Add(new Estudiante { Id = 3, Nombre = "Jaime", Genero = "Masculino", Edad = 29, UniversidadId = 1 });
            Estudiantes.Add(new Estudiante { Id = 4, Nombre = "Edgar", Genero = "Masculino", Edad = 35, UniversidadId = 1 });
            Estudiantes.Add(new Estudiante { Id = 5, Nombre = "Aleph", Genero = "Masculino", Edad = 32, UniversidadId = 2 });
            Estudiantes.Add(new Estudiante { Id = 6, Nombre = "Rodrigo", Genero = "Masculino", Edad = 28, UniversidadId = 2 });
            Estudiantes.Add(new Estudiante { Id = 7, Nombre = "Rosalia", Genero = "Femenino", Edad = 25, UniversidadId = 1 });
            Estudiantes.Add(new Estudiante { Id = 8, Nombre = "Ana", Genero = "Femenino", Edad = 21, UniversidadId = 2 });
            Estudiantes.Add(new Estudiante { Id = 9, Nombre = "Fernanda", Genero = "Femenino", Edad = 26, UniversidadId = 1 });
            Estudiantes.Add(new Estudiante { Id =10, Nombre = "Adriana", Genero = "Femenino", Edad = 27, UniversidadId = 1 });
            Estudiantes.Add(new Estudiante { Id = 11, Nombre = "Diana", Genero = "Femenino", Edad = 29, UniversidadId = 2 });
            Estudiantes.Add(new Estudiante { Id = 12, Nombre = "Alejandra", Genero = "Femenino", Edad = 24, UniversidadId = 2 });
            Estudiantes.Add(new Estudiante { Id = 13, Nombre = "Pedro", Genero = "No Binario", Edad = 28, UniversidadId = 1 });
            Estudiantes.Add(new Estudiante { Id = 14, Nombre = "Karla", Genero = "No Binario", Edad = 24, UniversidadId = 2 });
            Estudiantes.Add(new Estudiante { Id = 15, Nombre = "Fernando", Genero = "No Binario", Edad = 22, UniversidadId = 1 });
            Estudiantes.Add(new Estudiante { Id = 16, Nombre = "Carlos", Genero = "No Binario", Edad = 29, UniversidadId = 1 });
            Estudiantes.Add(new Estudiante { Id = 17, Nombre = "Jessica", Genero = "No Binario", Edad = 34, UniversidadId = 2 });
            Estudiantes.Add(new Estudiante { Id = 18, Nombre = "Daniel", Genero = "No Binario", Edad = 36, UniversidadId = 2 });

        }
        /// <summary>
        /// Se genera nueva coleccion, en el query se esta realizando el join de las universidades las cuales son las que se 
        /// pasan al final de la selccion 
        /// tablas Estudiante y Universidad
        /// </summary>
        public void SetCollectionStudentUniversity() {
            
            var coleccionNueva = from estudiante in Estudiantes
                                join universidad in Universidades
                                on estudiante.UniversidadId equals universidad.Id
                                select new { NombreEstudiante = estudiante.Nombre, Nombreuniversidad = universidad.Nombre };
            Console.WriteLine("Nueva coleccion: ");
            foreach (var coleccion in coleccionNueva) {
                Console.WriteLine("Estudiante {0} de la Universidad {1}", coleccion.NombreEstudiante,coleccion.Nombreuniversidad);
            }
            {

            }
        }
        /// <summary>
        /// Se realiza busqueda en la cual solo aparecen los generos maculinos de las escuelas 
        /// tablas Estudiante
        /// </summary>
        public void GetGenereMan() {
            IEnumerable<Estudiante> estudiantesMan = from alumno in Estudiantes where alumno.Genero == "Masculino" select alumno;
            Console.WriteLine("Estudiantes maculinos: ");
            foreach (var estudiante in estudiantesMan)
            {
                estudiante.MostrarEstudiante();
            }
        }
        /// <summary>
        /// Se realiza busqueda en la cual solo aparecen los generos femeninos de las escuelas 
        /// tablas Estudiante
        /// </summary>
        public void GetGenereWoman()
        {
            IEnumerable<Estudiante> estudiantesWoman = from alumno in Estudiantes where alumno.Genero == "Femenino" select alumno;
            Console.WriteLine("Estudiantes femeninos: ");
            foreach (var estudiante in estudiantesWoman)
            {
                estudiante.MostrarEstudiante();
            }
        }
        /// <summary>
        /// Se realiza busqueda en la cual solo aparecen los generos no binarios de las escuelas 
        /// tablas Estudiante 
        /// </summary>
        public void GetGenereNBinario()
        {
            IEnumerable<Estudiante> estudiantesNBinarios = from alumno in Estudiantes where alumno.Genero == "No Binario" select alumno;
            Console.WriteLine("Estudiantes no binarios: ");
            foreach (var estudiante in estudiantesNBinarios)
            {
                estudiante.MostrarEstudiante();
            }
        }
        /// <summary>
        /// Se realiza busqueda de estudiantes en los cuales se ordenan por edad 
        /// tablas Estudiante 
        /// </summary>
        public void OrdenarEstudiantesEdad() {
            var ordenarEstudiantes = from Estudiante in Estudiantes orderby Estudiante.Edad select Estudiante;
            Console.WriteLine("Estudantes ordenados segun edad:");
            foreach (Estudiante item in ordenarEstudiantes)
            {
                item.MostrarEstudiante();
            }
        }
        /// <summary>
        /// Se realiza consulta de estudiantes en la universidad de EBAC
        /// tablas Estudiante y Universidad
        /// </summary>
        public void MostrarUniversidadEBAC() {
            IEnumerable<Estudiante> estudiantesEBAC = from estudiante in Estudiantes
                                                      join Universidad in Universidades
                                                      on estudiante.UniversidadId equals Universidad.Id
                                                      where Universidad.Nombre == "EBAC"
                                                      select estudiante;
            Console.WriteLine("Estudiantes de EBAC");
            foreach(Estudiante alumno in estudiantesEBAC)
            {
                alumno.MostrarEstudiante();
            }
                                                      
        }
        /// <summary>
        /// Se realiza consulta de estudiantes mediante el parametro de universidadid en las universidades 
        /// tablas Estudiante y Universidad
        /// </summary>
        /// <param name="UniversidadId"></param>
        public void MostrarUniversidad(int UniversidadId)
        {
            IEnumerable<Estudiante> estudiantes = from estudiante in Estudiantes
                                                      join Universidad in Universidades
                                                      on estudiante.UniversidadId equals Universidad.Id
                                                  where Universidad.Id == UniversidadId
                                                  select estudiante;
            Console.WriteLine("Estudiantes de universidad {0}", UniversidadId);
            foreach (Estudiante alumno in estudiantes)
            {
                alumno.MostrarEstudiante();
            }

        }
    }
 

    class Universidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public void MostrarUniversidad() {
            Console.WriteLine("Universidad {0} tiene el Id {1} ", Nombre,Id);
        }
    }
    class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public int UniversidadId { get; set; }

        public void MostrarEstudiante() {
            Console.WriteLine("\tNombre: {0}, tiene el Id {1}, Edad {2}  de genero {3} y asiste a la Universidad {4}. ", Nombre,Id,Edad,Genero,UniversidadId);
        }
    }
}
