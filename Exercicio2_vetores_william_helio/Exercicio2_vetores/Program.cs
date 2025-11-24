using System;

namespace codigo
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade;
            int vectorrrr;
            Console.WriteLine("Quantas letras tem sua palavra?");
            quantidade = int.Parse(Console.ReadLine());
            char[] letras = new char[quantidade];
            Console.WriteLine("\nDigite as " + quantidade + " letras:");
            for (vectorrrr = 0; vectorrrr < quantidade; vectorrrr++)
            {
                Console.Write("Letra " + (vectorrrr + 1) + ": ");
                letras[vectorrrr] = char.Parse(Console.ReadLine());
            }
            Console.Write("\nPalavra completa: ");
            for (int i = 0; i < letras.Length; i++)
            {
                Console.Write(letras[i]);
            }
            Console.WriteLine("\n\nletras separadas:");
            for (int i = 0; i < letras.Length; i++)
            {
                Console.WriteLine(letras[i]);
            }
        }
    }
}