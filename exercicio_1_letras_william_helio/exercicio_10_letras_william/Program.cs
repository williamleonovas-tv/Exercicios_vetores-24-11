using System;

namespace codigo
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letras = new char[10];
            int vectorrrr;
            Console.WriteLine("Digita 10 letras ai pra eu fazer um ngc");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Letra " + (i + 1) + ": ");
                letras[i] = char.Parse(Console.ReadLine());
            }
            Console.Write("\nPalavra completa: ");
            for(int i = 0;i < 10; i++)
            {
                Console.Write(letras[i]);
            }
            Console.WriteLine("\n\nletras separadas:");
            for(uint i = 0;i < 10; i++)
            {
                Console.WriteLine(letras[i]);
            }
        }
    }
}