using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_FundamentosDesenvolvimentoC.Exercicio04
{
    public class Aniversario
    {
        public static void Executar()
        {
            Console.Clear();
            Console.Write("Digite sua data de nascimento (dd/mm/aaaa): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime dataNascimento))
            {
                int diasFaltantes = CalcularDiasParaProximoAniversario(dataNascimento);
                Console.WriteLine($"Faltam {diasFaltantes} dias para o seu próximo aniversário.");

                if (diasFaltantes < 7)
                {
                    Console.WriteLine("Seu aniversário está chegando, parabéns antecipado.");
                }
            }
            else
            {
                Console.WriteLine("Data inválida, certifique-se de digitar no formato correto.");
            }
        }

        public static int CalcularDiasParaProximoAniversario(DateTime dataNascimento)
        {
            DateTime hoje = DateTime.Today;
            DateTime proximoAniversario = new DateTime(hoje.Year, dataNascimento.Month, dataNascimento.Day);

            if (proximoAniversario < hoje)
            {
                proximoAniversario = proximoAniversario.AddYears(1);
            }

            return (proximoAniversario - hoje).Days;
        }
    }
}
