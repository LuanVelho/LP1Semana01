using System;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numero1 = 8;
            short numero2 = 16;
            int numero3 = 32;
            long numero4 = 64;


            Console.WriteLine(numero1);
            Console.WriteLine(numero2);
            Console.WriteLine(numero3);
            Console.WriteLine(numero4);

            char copyright = '\u00A9';
            char borboleta = '\u2A1D';

            Console.WriteLine(copyright);
            Console.WriteLine(borboleta);

            float numero5 = 5.653f;
            decimal numero6 = 8.5432m;
            

            Console.WriteLine(numero5);
            Console.WriteLine(numero6);
            


        }
    }
}
