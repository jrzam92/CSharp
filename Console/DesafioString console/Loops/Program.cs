using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DesafioLoopTraerPromedio();
            //dowhileLoop();
            //whileLoop();
            //ForLoop();
            //ContinueBreakLoop();
        }
        public static void dowhileLoop() {
            int contador = 0;
            do
            {
                Console.WriteLine("El valor de contador es {0}",contador);
                contador += 5;
            } while (contador<=50);

        }
        public static void whileLoop() { 
            
            string inputuser="";
            int contador = 0;
            while (inputuser.Equals(""))
            {
                Console.WriteLine("Mejora tu puntuacion dando enter.... \n\nPresiona cualquier tecla para salir...");
                inputuser=Console.ReadLine();
                Console.WriteLine(contador);
                contador++;
            }
        }
        public static void ForLoop() {
            Console.WriteLine("Proporcioname el numero de la tabla de multiplicar");
            int numeroTabla=int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("La multiplicacion de {0} * {1} = {2}",numeroTabla,i ,numeroTabla*i);
            }
        }
        public static void ContinueBreakLoop() {
            for (int i = 0; i < 10; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine("El numero {0} es par ", i);
                    continue;
                }
                Console.WriteLine("El numero {0} es impar " ,i);
            }
            Console.Read();
        }

        public static void DesafioLoopTraerPromedio() {

            string ingreso = "0";
            int contador = 0;
            int total = 0;
            int intentoNumero = 0;
            string alumnoNombre = string.Empty;
            Console.WriteLine("Escriba el nombre del alumno a calificar :");
            alumnoNombre=Console.ReadLine();
            Console.WriteLine("Puede finalizar de ingresar calificaciones escribiendo \"fin\" para obtener el promedio");
            do
            { 
                switch (contador)
                {
                    case 0:
                        Console.WriteLine("Instructor intoduzca la calificacion de Matematicas: "); 
                        break;
                    case 1:
                        Console.WriteLine("Instructor intoduzca la calificacion de Diseño de videojugos: ");
                        break;
                    case 2:
                        Console.WriteLine("Instructor intoduzca la calificacion de Historia de videojuegos: ");
                        break;
                    case 3:
                        Console.WriteLine("Instructor intoduzca la calificacion de Metodologia de investigacion: ");
                        break;
                    case 4:
                        Console.WriteLine("Instructor intoduzca la calificacion de Programacion: ");
                        break;
                    case 5:
                        Console.WriteLine("Instructor intoduzca la calificacion de Contexto Estetico: ");
                        break;
                    
                }
                ingreso = Console.ReadLine();
                if (int.TryParse(ingreso, out intentoNumero) && intentoNumero >= 0 && intentoNumero < 11)
                {
                    total += intentoNumero;
                }
                else {
                    if (!(ingreso.Equals("fin"))) {
                        Console.WriteLine("Favor de ingresar calificaciones de 0 a 10 ");
                    }
                }
                contador++;

            } while (ingreso!="fin");
            if (ingreso.Equals("fin")) {
                double promedio = (double)total / (double)contador;
                Console.WriteLine("El promedio del alumno {2} fue de :{0} el alumno {1}", promedio, promedio<6?"Reprobo":"Aprobo",alumnoNombre);
            }
            Console.Read();

        }

    }
}
