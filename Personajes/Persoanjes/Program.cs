using PandorasCharacter.Model;
using System;

namespace PandorasCharacter
{
    public class Program
    {
         
        static void Main(string[] args)
        {
            Personaje personaje=new Personaje();
            var resquest=CreateCaharacter(personaje);
            Console.WriteLine("\n\n\nRequest obtenido: --->" + (resquest?"Satisfactorio":"No se logro"));
            Console.ReadKey();
        }
        public static bool CreateCaharacter(Personaje personaje)
        {
            //Titulo
            string titulo = "CREACION DE PERSONAJES";
            string tituloFinal = "ESTE ES EL RESULTADO DE TU PERSONAJE";
            //Preguntas al usuario
            string _Nombre = "Cual es el nombre?";
            string _Edad = "Cual es la edad? ";
            string _Estatura = "Cual es la estatura? ";
            string _Peso = "Cual es el peso? "; 
            string _Sexo = "Cual es el genero?";
            string _Contextura="Cual es la contextura?";
            string _ColorOjos="Cual es el color de ojos?";
            string _ColorCabello="Cual es el color de cabello?";
            string _ColorPiel="Cual es el color de Piel?";
            string _Raza="Cual es la Raza? ";
            string _DescripcionGeneral="Describe un brevemente su biografia?";
            string _Health="Cual seria el rango de salud?, especifica de 0 a 100";
            string _Power= "Cual seria el rango de poder?, especifica de 0 a 100";
            string _Energy= "Cual seria el rango de energia?, especifica de 0 a 100";
            //Extras
            string saltoLinea = "\n";

            Console.WriteLine(titulo);
            Console.WriteLine("====================================");Console.WriteLine("====================================");
            Console.WriteLine(_Nombre);
             personaje.Nombre = Console.ReadLine();
            Console.WriteLine("===================================="); Console.WriteLine("====================================");
            Console.WriteLine(_Edad);
            personaje.Edad =Console.ReadLine();
            Console.WriteLine("===================================="); Console.WriteLine("====================================");
            Console.WriteLine(_Estatura);
            personaje.Estatura =Console.ReadLine();
            Console.WriteLine("===================================="); Console.WriteLine("====================================");
            Console.WriteLine(_Peso);
            personaje.Peso =Console.ReadLine();
            Console.WriteLine("===================================="); Console.WriteLine("====================================");
            Console.WriteLine(_Sexo);
            personaje.Sexo =Console.ReadLine();
            Console.WriteLine("===================================="); Console.WriteLine("====================================");
            Console.WriteLine(_Contextura);
            personaje.Contextura =Console.ReadLine();
            Console.WriteLine("===================================="); Console.WriteLine("====================================");
            Console.WriteLine(_ColorOjos);
            personaje.ColorOjos =Console.ReadLine();
            Console.WriteLine("===================================="); Console.WriteLine("====================================");
            Console.WriteLine(_ColorCabello);
            personaje.ColorCabello =Console.ReadLine();
            Console.WriteLine("===================================="); Console.WriteLine("====================================");
            Console.WriteLine(_ColorPiel);
            personaje.ColorPiel =Console.ReadLine();
            Console.WriteLine("===================================="); Console.WriteLine("====================================");
            Console.WriteLine(_Raza);
            personaje.Raza=Console.ReadLine();
            Console.WriteLine("===================================="); Console.WriteLine("====================================");
            Console.WriteLine(_DescripcionGeneral);
            personaje.DescripcionGeneral =Console.ReadLine();
            Console.WriteLine("===================================="); Console.WriteLine("====================================");
            Console.WriteLine(_Health);
            personaje.Health =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("===================================="); Console.WriteLine("====================================");
            Console.WriteLine(_Power);
            personaje.Power  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("===================================="); Console.WriteLine("====================================");
            Console.WriteLine(_Energy);
            personaje.Energy  = Convert.ToInt32(Console.ReadLine());

            string Resultado =
            saltoLinea+"El nombre de tu personaje es : "+ personaje.Nombre +
            saltoLinea+"La edad que tiene es de : " + personaje.Edad +
            saltoLinea+"Mide :"    + personaje.Estatura +
            saltoLinea+"El peso es de : "  + personaje.Peso +
            saltoLinea+"Su genero es : "   + personaje.Sexo +
            saltoLinea+"Su contextura es : "  + personaje.Contextura +
            saltoLinea+"Su color de ojos es : " + personaje.ColorOjos +
            saltoLinea+"Su color de cabello es : "   + personaje.ColorCabello +
            saltoLinea+"Su color de piel es: " + personaje.ColorPiel +
            saltoLinea+"Su Raza es : "  + personaje.Raza +
            saltoLinea+"Biografia : "+ saltoLinea + personaje.DescripcionGeneral +
            saltoLinea+"Salud : "  + personaje.Health +
            saltoLinea+"Poder : "  + personaje.Power +
            saltoLinea+"Enrgia : "  + personaje.Energy;
            Console.WriteLine("===================================="); Console.WriteLine("====================================");
            Console.WriteLine(tituloFinal);
            Console.WriteLine("====================================");
            Console.WriteLine(Resultado);
            Console.WriteLine("====================================");
            Console.ReadKey();
            return true;
        }

    }
}
