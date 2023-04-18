using System;

namespace TipoDato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte mibyte=254;
            sbyte misbyte=126;
            int miint= 2147483646;
            uint miuint= 4294967294;
            short mishort= 32766;
            ushort miushort= 65534;
            long milong= 9223372036854775806;
            ulong miulong= 18446744073709551614;
            float mifloat = 3.402823f;
            double midouble= 1.79769313486232d;
            char michar='a';
            bool mibool=true;
            object miobject="Hello";
            string mistring="Yo controlo el texto";
            decimal midecimal = 1.79769313486232m;

            Console.WriteLine("+" + mibyte
                           + "\n+" + misbyte
                           +"\n+"+ miint
                           +"\n+"+ miuint
                           +"\n+"+ mishort
                           +"\n+"+ miushort
                           +"\n+"+ milong
                           +"\n+"+ miulong
                           +"\n+"+ mifloat
                           +"\n+"+ midouble
                           +"\n+"+ michar
                           +"\n+"+ mibool
                           +"\n+"+ miobject
                           +"\n+"+ mistring
                           +"\n+"+ midecimal
            );
            Console.ReadKey();


        }
    }
}
