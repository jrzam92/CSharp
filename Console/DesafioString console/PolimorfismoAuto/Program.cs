using System;
using System.Collections.Generic;

namespace PolimorfismoAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var autos = new List<Auto> {
                new Audi(200,"azul","A4"),
                new BMW(250,"rojo","M3"),

            };
            //Aqui se observa el override
            //
            //
            //
            //de como usan el mismo metodo propio sin usar el del padre Auto
            foreach (var auto in autos) {
                Console.WriteLine(auto.FixedCar());
            }
            Console.WriteLine("============");
            Console.WriteLine("============");
            Auto auto1 = new BMW(320, "verde", "Z3");
            Auto auto2 = new Audi(450, "negro", "A3");
            //Aqui se observa el new de como usan el mismo metodo propio sin usar el del padre Auto
            Console.WriteLine(auto1.getDetalles());
            Console.WriteLine(auto2.getDetalles());

            Console.WriteLine("============");
            Console.WriteLine("============");
            BMW bmw=new BMW(320, "plateado", "M5");
            //Utiliza el metodo propio de repado sin usar el del padre 
            Console.WriteLine(bmw.getDetalles());
            Console.WriteLine("============");
            Console.WriteLine("============");
            //Aqui se usa el metodo del padre que es auto 
            Auto auto3 = (Auto)bmw;
            Console.WriteLine(auto3.getDetalles());
            Console.WriteLine("============");
            Console.WriteLine("============");

            ///Seccion de sellado Sealed
            ///Funciona para que no se herede la clase 
             Console.WriteLine("============");
            Console.WriteLine("======Seccion de Sealed polimorfismo======");
            //Solo se pueden sellar metodos con override (sore escritos)
            M3 m3=new M3(250,"morado","M3 - Super Turbo");
            Console.WriteLine(m3.FixedCar());
            Console.WriteLine("============");
            Console.WriteLine("============");
            auto1.setAutoInfo(1234,"Amanda Gutierrez");
            auto2.setAutoInfo(1235, "Arnold Cristobal");
            Console.WriteLine(auto1.getAutoInfo());
            Console.WriteLine(auto2.getAutoInfo());
            
            
            
            Console.Read();

        }
    }
}
