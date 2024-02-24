using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            double xx = 1.23456;
            int ii = 19;

            string s1 = $"xx={xx:f2}";
            string s2 = $"xx={xx:p1}";

            string s3 = $"ii={ii:X}";
            string s4 = $"ii={ii:C}";




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

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);

        }
    }
}
