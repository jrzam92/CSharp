using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LinqSQL
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataClasses1DataContext dataContext;
        /// <summary>
        /// Nota : 
        /// 
        /// Como buena practica es bueno poner los try ya que con esto podemos manejar los errores 
        /// aunque tambien se requiere definir que se tiene que hacer si el proceso llegara a fallar 
        /// 
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            #region Conexion a la DB
            /// <summary>
            /// Revisar las referencias buscando system.configuration
            /// Se tiene que agregar una clase de LINQ 
            /// </summary>
            string connectionString = ConfigurationManager.ConnectionStrings["LinqSQL.Properties.Settings.ConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(connectionString);
            #endregion 
            //Se tiene que correr secuencialmente para al final solo obtener el ultimo metodo
            //Metodo que tiene las universidades 
            //AgregarUniversidad();
            //Metodo que tiene a los estudiantes 
            //AgregarEstudiantes();
            ////Metodo que tiene las Materias 
            //AgregarMaterias();
            ////Metodo de asociacion de estudiantes con materias
            //AgregarEstudiantesMaterias();
            ////Se obtiene la universidad de Mateo
            //ObtenerUniversidadMateo();
            //ObtenerEstudiantesESDIE();
            //ObtenerUniversidadesEstudiantesHombres();
            //ObtenerUniversidadesEstudiantesMujeres();
            //ObtenerUniversidadesEstudiantesHombresMujeres();
            //ObetenerMateriasESDIE();
            //ObetenerMateriasEBAC();
            //ObetenerMateriasESDIEEBAC();
            //ActualizarMateo();
            //EliminarEstudiante();


           
        }
        /// <summary>
        /// Metodo que hace la agrega de los registros de las universidades
        /// Se tiene que ir al explorador de servicios y agregar la tabla correspondiente
        /// 
        /// </summary>
        public void AgregarUniversidad() {
            string query = "delete from Universidad";
            dataContext.ExecuteCommand(query);
            ///Tablas que se cargan desde la DB 
            Universidad esdie= new Universidad();
            esdie.Nombre = "ESDIE";
            dataContext.Universidad.InsertOnSubmit(esdie);
            Universidad ebac = new Universidad();
            ebac.Nombre = "EBAC";
            dataContext.Universidad.InsertOnSubmit(ebac);
            dataContext.SubmitChanges();
            //Para visualizar la tabla es con
            DataGridPrincipal.ItemsSource = dataContext.Universidad;
        }
        /// <summary>
        /// Metodo que agrega a los estudiantes a sus diferentes universidades
        /// Se tiene que ir al explorador de servicios y agregar la tabla correspondiente
        /// </summary>
        public void AgregarEstudiantes() {
            Universidad esdie = dataContext.Universidad.First(uni => uni.Nombre.Equals("ESDIE"));
            Universidad ebac = dataContext.Universidad.First(uni => uni.Nombre.Equals("EBAC"));

            List<Estudiante> estudiante = new List<Estudiante>();
            estudiante.Add(new Estudiante{ Nombre="Karla",Genero="Femenino",UniversidadId=esdie.Id});
            estudiante.Add(new Estudiante{ Nombre = "Mateo", Genero = "Masculino", Universidad = esdie });
            estudiante.Add(new Estudiante { Nombre = "Laura", Genero = "Femenino", Universidad = ebac });
            estudiante.Add(new Estudiante { Nombre = "Carlos", Genero = "Masculino", Universidad = esdie });
            dataContext.Estudiante.InsertAllOnSubmit(estudiante);
            dataContext.SubmitChanges();
            DataGridPrincipal.ItemsSource = dataContext.Estudiante;
        }
        /// <summary>
        /// Metodo que agrega las materias a sus diferentes universidades
        /// Se tiene que ir al explorador de servicios y agregar la tabla correspondiente
        /// </summary>
        public void AgregarMaterias() {
            dataContext.Materia.InsertOnSubmit(new Materia { Nombre = "Matematicas" });
            dataContext.Materia.InsertOnSubmit(new Materia { Nombre = "Fisica" });

            dataContext.SubmitChanges();
            DataGridPrincipal.ItemsSource=dataContext.Materia;

        }
        /// <summary>
        /// Metodo que agrega las materias y alumnos asociados 
        /// Se tiene que ir al explorador de servicios y agregar la tabla correspondiente
        /// </summary>
        public void AgregarEstudiantesMaterias() { 
            Estudiante Karla = dataContext.Estudiante.First(es=>es.Nombre.Equals("Karla"));
            Estudiante Mateo = dataContext.Estudiante.First(es => es.Nombre.Equals("Mateo"));
            Estudiante Laura = dataContext.Estudiante.First(es => es.Nombre.Equals("Laura"));
            Estudiante Carlos = dataContext.Estudiante.First(es => es.Nombre.Equals("Carlos"));

            Materia Matematicas = dataContext.Materia.First(ma => ma.Nombre.Equals("Matematicas"));
            Materia Fisica = dataContext.Materia.First(ma => ma.Nombre.Equals("Fisica"));
            //Insercion comun 
            dataContext.EstudianteMateria.InsertOnSubmit(new EstudianteMateria { Estudiante = Karla, Materia = Matematicas });
            dataContext.EstudianteMateria.InsertOnSubmit(new EstudianteMateria { Estudiante = Mateo, Materia = Matematicas });
            EstudianteMateria emMateo = new EstudianteMateria();
            emMateo.Estudiante = Mateo;
            //emMateo.Materia = Fisica;--> por si no funciona el de abajo
            emMateo.MateriaId = Fisica.Id;

            //Insercion de materia de fisica para Mateo
            dataContext.EstudianteMateria.InsertOnSubmit(emMateo);
            
            dataContext.EstudianteMateria.InsertOnSubmit(new EstudianteMateria { Estudiante = Laura, Materia = Fisica });

            dataContext.SubmitChanges();
            DataGridPrincipal.ItemsSource = dataContext.EstudianteMateria;


        }
        /// <summary>
        /// Metodo que obtiene la universidad de mateo
        /// </summary>
        public void ObtenerUniversidadMateo() { 
        
            Estudiante Mateo = dataContext.Estudiante.First(es=>es.Nombre.Equals("Mateo"));
            Universidad mateoUni = Mateo.Universidad;

            List<Universidad> universidades= new List<Universidad>();
            universidades.Add(mateoUni);

            DataGridPrincipal.ItemsSource = universidades;

        }
        /// <summary>
        /// Metodo que puede obtner Materias de Mateo con LINQ (busqueda de mateo con sus materias)
        /// </summary>
        public void ObtenerMateriasMateo()
        {
            Estudiante Mateo = dataContext.Estudiante.First(es => es.Nombre.Equals("Mateo"));

            var materiasMateo = from em in Mateo.EstudianteMateria select em.Materia;
            DataGridPrincipal.ItemsSource= materiasMateo;


        }
        /// <summary>
        /// Obtener estudiantes de ESDIE con LINQ (busqueda de estudiantes con la universidad de ESDIE)
        /// </summary>
        public void ObtenerEstudiantesESDIE() {

            var estudiantesESDIE = from estudiante in dataContext.Estudiante where estudiante.Universidad.Nombre == "ESDIE" select estudiante;
            DataGridPrincipal.ItemsSource=estudiantesESDIE;
        }
        public void ObtenerUniversidadesEstudiantesHombres() {
            var uniHombres = from estudiante in dataContext.Estudiante
                             join universidad in dataContext.Universidad
                             on estudiante.Universidad equals universidad
                             where estudiante.Genero == "Masculino"
                             select estudiante;

            DataGridPrincipal.ItemsSource = uniHombres;
        }
        public void ObtenerUniversidadesEstudiantesMujeres()
        {
            var uniHombres = from estudiante in dataContext.Estudiante
                             join universidad in dataContext.Universidad
                             on estudiante.Universidad equals universidad
                             where estudiante.Genero == "Femenino"
                             select estudiante;

            DataGridPrincipal.ItemsSource = uniHombres;
        }
        public void ObtenerUniversidadesEstudiantesHombresMujeres()
        {
            var uniHombres = from estudiante in dataContext.Estudiante
                             join universidad in dataContext.Universidad
                             on estudiante.Universidad equals universidad
                             where (estudiante.Genero == "Femenino" || estudiante.Genero == "Masculino") 
                             select estudiante;

            DataGridPrincipal.ItemsSource = uniHombres;
        }
        /// <summary>
        /// Metodo que obtiene materias de ESDIE
        /// </summary>
        public void ObetenerMateriasESDIE() {
// el "em" empieza es --> em es como la variable parecido al foreach del listado de estudiante materia
// la variable de "estudiante" es la variable para realizar la union correspondiente de la universidad 
            var materiasESDIE = from em in dataContext.EstudianteMateria
                                join estudiante in dataContext.Estudiante
                                on em.EstudianteId equals estudiante.Id
                                where estudiante.Universidad.Nombre == "ESDIE"
                                select em.Materia;
            DataGridPrincipal.ItemsSource = materiasESDIE;

        }
        public void ObetenerMateriasEBAC()
        {
            // el "em" empieza es --> em es como la variable parecido al foreach del listado de estudiante materia
            // la variable de "estudiante" es la variable para realizar la union correspondiente de la universidad 
            var materiasESDIE = from em in dataContext.EstudianteMateria
                                join estudiante in dataContext.Estudiante
                                on em.EstudianteId equals estudiante.Id
                                where estudiante.Universidad.Nombre == "EBAC"
                                select em.Materia;
            DataGridPrincipal.ItemsSource = materiasESDIE;

        }
        public void ObetenerMateriasESDIEEBAC()
        {
            // el "em" empieza es --> em es como la variable parecido al foreach del listado de estudiante materia
            // la variable de "estudiante" es la variable para realizar la union correspondiente de la universidad 
            var materiasESDIE = from em in dataContext.EstudianteMateria
                                join estudiante in dataContext.Estudiante
                                on em.EstudianteId equals estudiante.Id
                                where (estudiante.Universidad.Nombre == "EBAC"|| estudiante.Universidad.Nombre == "ESDIE")
                                select em.Materia;
            DataGridPrincipal.ItemsSource = materiasESDIE;

        }

        public void ActualizarMateo() { 
            
            Estudiante mateo=dataContext.Estudiante.FirstOrDefault(es=>es.Nombre=="Mateo");
            mateo.Nombre = "Mateus";
            dataContext.SubmitChanges();
            DataGridPrincipal.ItemsSource = dataContext.Estudiante;
        }

        public void EliminarEstudiante() {
            Estudiante estudiante = dataContext.Estudiante.FirstOrDefault(es => es.Nombre == "Carlos");
            dataContext.Estudiante.DeleteOnSubmit(estudiante);
            dataContext.SubmitChanges();
            DataGridPrincipal.ItemsSource = dataContext.Estudiante;
        }

    }
    

 
}
