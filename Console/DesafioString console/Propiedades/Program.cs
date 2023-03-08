using System;

namespace Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Caja caja = new Caja();
            Console.WriteLine("Escribe de las siguientes cajas quieres calcular su volumen:\n\t*PlaysStation 5\n\t*Wii U\n\t*Xbox X\\S\n\t*Nintendo Switch\n\t*PSP  ");
            caja.NombreCaja=Console.ReadLine();
            Console.WriteLine("Calcula la caja de  {0}: ", caja.NombreCaja);
            Console.WriteLine("Necesito el alto: ");
            caja.Alto=double.Parse(Console.ReadLine());
            Console.WriteLine("Necesito el ancho: ");
            caja.Ancho=double.Parse(Console.ReadLine());
            Console.WriteLine("Necesito el largo: ");
            caja.Largo=double.Parse(Console.ReadLine());

            Console.WriteLine("El alto de la caja {1} es de : {0} cm ", caja.Alto, caja.NombreCaja);
            Console.WriteLine("El ancho de la caja {1} es de : {0} cm ", caja.Ancho, caja.NombreCaja);
            Console.WriteLine("El largo de la caja {1} es de : {0} cm ", caja.Largo , caja.NombreCaja);
            Console.WriteLine("El volumen de la caja {1} es de : {0} cm ^ 3",caja.Volumen, caja.NombreCaja);
        }
    }
}
