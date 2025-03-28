using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_FundamentosDesenvolvimentoC.Exercicio10
{
    public class JogoAdivinhacao
    {
        public static void Executar()
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 51);
            int tentativas = 5;

            Console.Clear();
            Console.WriteLine("Jogo de Adivinhação");
            Console.WriteLine("Tente adivinhar o número de 1 a 50. Você tem 5 tentativas!");

            for (int i = 1; i <= tentativas; i++)
            {
                Console.Write($"\nTentativa {i}, digite seu palpite: ");

                if (!int.TryParse(Console.ReadLine(), out int palpite) || palpite < 1 || palpite > 50)
                {
                    Console.WriteLine("Número inválido, digite um valor entre 1 e 50.");
                    i--; 
                    continue;
                }

                if (palpite == numeroSecreto)
                {
                    Console.WriteLine($"\nParabéns! Você acertou o número {numeroSecreto} em {i} tentativas!");
                    return;
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Dica: O número é menor!");
                }
                else
                {
                    Console.WriteLine("Dica: O número é maior!");
                }
            }

            Console.WriteLine($"\nFim de jogo! O número correto era {numeroSecreto}.");
        }
    }
}
