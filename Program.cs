using System;

namespace VerificacaoMaioridade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua idade: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int idade))
            {
                if (idade >= 18)
                {
                    Console.WriteLine("Você é maior de idade.");
                }
                else
                {
                    Console.WriteLine("Você é menor de idade.");
                }
            }

            else
            {
                Console.WriteLine("Erro! Tente novamente.");
            }
        }
    }
}
