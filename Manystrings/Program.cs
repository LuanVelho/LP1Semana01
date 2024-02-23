using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensagem = "Funciona, definitivamente funciona...";
            Console.WriteLine(mensagem);

            string emojis1 = "\u265F";
            string emojis2 = "\u2665";


            string mensagem1 = "Bom dia" + 2;

            string nome = "Luan";
            string mensagem2 = $"Meu nome é {nome}";

            Console.WriteLine(mensagem1);

            Console.WriteLine(mensagem2);

            Console.WriteLine(emojis1);
            Console.WriteLine(emojis2);

        }
    }
}
