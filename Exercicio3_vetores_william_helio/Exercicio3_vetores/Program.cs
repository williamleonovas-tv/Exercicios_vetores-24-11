using System;
// Importante adicionar System.Linq para usar o método Contains()
using System.Linq;
namespace codigo
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade;
            int vectorrrr;

            Console.WriteLine("Quantas letras tem sua palavra?");
            if (!int.TryParse(Console.ReadLine(), out quantidade))
            {
                Console.WriteLine("Entrada inválida. Usando tamanho padrão de 5.");
                quantidade = 5;
            }

            char[] letras = new char[quantidade];
            Console.WriteLine("\nDigite as " + quantidade + " letras:");
            for (vectorrrr = 0; vectorrrr < quantidade; vectorrrr++)
            {
                Console.Write("Letra " + (vectorrrr + 1) + ": ");
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    letras[vectorrrr] = char.Parse(input.ToUpper());
                }
                else
                {
                    letras[vectorrrr] = ' ';
                }
            }

            Console.WriteLine("\n--- Jogo de Adivinhação de Letra ---");
            Console.WriteLine("Você tem 3 tentativas para adivinhar uma letra na palavra.");

            int tentativas = 3;
            while (tentativas > 0)
            {
                Console.WriteLine($"\nTentativas restantes: {tentativas}");
                Console.Write("Digite uma letra para tentar: ");
                string tentativaInput = Console.ReadLine();

                if (string.IsNullOrEmpty(tentativaInput) || tentativaInput.Length != 1)
                {
                    Console.WriteLine("Entrada inválida. Digite apenas uma letra.");
                    continue; 
                }
                char letraTentativa = char.Parse(tentativaInput.ToUpper());
                if (letras.Contains(letraTentativa))
                {
                    Console.WriteLine($"Parabéns! A letra '{letraTentativa}' existe na palavra!");
                }
                else
                {
                    Console.WriteLine($"Ops. A letra '{letraTentativa}' não está na palavra.");
                }

                tentativas--;
            }
            Console.WriteLine("\n--- Resultado Final ---");

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
