using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_FundamentosDesenvolvimentoC.Exercicio05
{

    public class TempoFormatura
    {
        public static void Executar()
        {
            Console.Clear();
            Console.Write("Digite a data atual (dd/MM/yyyy): ");
            if (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataAtual))
            {
                Console.WriteLine("Data inválida, use o formato dd/MM/yyyy.");
                return;
            }

            DateTime dataFormatura = new DateTime(2026, 12, 15);

            if (dataAtual > DateTime.Today)
            {
                Console.WriteLine("Erro: A data informada não pode ser no futuro!");
                return;
            }

            if (dataAtual > dataFormatura)
            {
                Console.WriteLine("Parabéns! Você já deveria estar formado!");
                return;
            }

            TimeSpan diferenca = dataFormatura - dataAtual;
            DateTime tempData = new DateTime(diferenca.Ticks);
            int anos = tempData.Year - 1;
            int meses = tempData.Month - 1;
            int dias = tempData.Day - 1;

            Console.WriteLine($"Faltam {anos} anos, {meses} meses e {dias} dias para sua formatura!");

            if ((dataFormatura - dataAtual).TotalDays < 180)
            {
                Console.WriteLine("A reta final chegou! Prepare-se para a formatura!");
            }
        }
    }
}
