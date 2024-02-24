using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Writeline("Por favor escreva um número inteiro:");
            string str = Console.ReadLine();
            int inteiro = int.Parse(str);
            Console.WriteLine(inteiro);

            Console.WriteLine("Por favor escreva um número real");
            string realzinho = Console.ReadLine();
            float real = float.Parse(realzinho);
            Console.WriteLine(real);

            int resultado = inteiro + real;
            Console.WriteLine($"{inteiro} + {real} = {resultado}");



        }
    }
}
