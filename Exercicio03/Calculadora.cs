using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_FundamentosDesenvolvimentoC.Exercicio03
{
    public class Calculadora
    {
        public static void Executar()
        {
            Console.Clear();
            Console.Write("Digite o primeiro número: ");
            if (!double.TryParse(Console.ReadLine(), out double numero1))
            {
                Console.WriteLine("Entrada inválida, use apenas números válidos.");
                return;
            }

            Console.Write("Digite o segundo número: ");
            if (!double.TryParse(Console.ReadLine(), out double numero2))
            {
                Console.WriteLine("Entrada inválida, use apenas números válidos.");
                return;
            }

            Console.WriteLine("\n=== Escolha a operação ===");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.Write("Digite a opção: ");

            string opcao = Console.ReadLine();
            double resultado;

            switch (opcao)
            {
                case "1":
                    resultado = numero1 + numero2;
                    Console.WriteLine($"\nResultado: {resultado}");
                    break;
                case "2":
                    resultado = numero1 - numero2;
                    Console.WriteLine($"\nResultado: {resultado}");
                    break;
                case "3":
                    resultado = numero1 * numero2;
                    Console.WriteLine($"\nResultado: {resultado}");
                    break;
                case "4":
                    if (numero2 == 0)
                    {
                        Console.WriteLine("Erro: divisão por zero não permitida.");
                    }
                    else
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine($"\nResultado: {resultado}");
                    }
                    break;
                default:
                    Console.WriteLine("\nOpção inválida!");
                    break;
            }
        }
    }
}
