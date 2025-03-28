using System;
using AT_FundamentosDesenvolvimentoC.Exercicio01;
using AT_FundamentosDesenvolvimentoC.Exercicio02;
using AT_FundamentosDesenvolvimentoC.Exercicio03;
using AT_FundamentosDesenvolvimentoC.Exercicio04;
using AT_FundamentosDesenvolvimentoC.Exercicio05;
using AT_FundamentosDesenvolvimentoC.Exercicio06;
using AT_FundamentosDesenvolvimentoC.Exercicio07;
using AT_FundamentosDesenvolvimentoC.Exercicio08;
using AT_FundamentosDesenvolvimentoC.Exercicio09;
using AT_FundamentosDesenvolvimentoC.Exercicio10;
using AT_FundamentosDesenvolvimentoC.Exercicio11;
using AT_FundamentosDesenvolvimentoC.Exercicio12;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Escolha um Exercício para Executar ===");
            Console.WriteLine("1 - Exercício 1");
            Console.WriteLine("2 - Exercício 2");
            Console.WriteLine("3 - Exercício 3");
            Console.WriteLine("4 - Exercício 4");
            Console.WriteLine("5 - Exercício 5");
            Console.WriteLine("6 - Exercício 6");
            Console.WriteLine("7 - Exercício 7");
            Console.WriteLine("8 - Exercício 8");
            Console.WriteLine("9 - Exercício 9");
            Console.WriteLine("10 - Exercício 10");
            Console.WriteLine("11 - Exercício 11");
            Console.WriteLine("12 - Exercício 12");
            Console.WriteLine("0 - Sair");
            Console.Write("\nDigite a opção desejada: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    PrimeiroPrograma.Executar();
                    break;
                
                case "2":
                    CifradorNome.Executar();
                    break;
                case "3":
                    Calculadora.Executar();
                    break;
                case "4":
                    Aniversario.Executar();
                    break;
                case "5":
                    TempoFormatura.Executar();
                    break;
                case "6":
                    AlunoCadastrado.Executar();
                    break;
                case "7":
                    TransacoesBancarias.Executar();
                    break;
                case "8":
                    FuncionariosSalarios.Executar();
                    break;
                case "9":
                    ControleEstoque.Executar();
                    break;
                case "10":
                    JogoAdivinhacao.Executar();
                    break;
                case "11":
                    Contatos.Executar();
                    break;
                case "12":
                    Contatos2.Executar();
                    break;
                case "0":
                    Console.WriteLine("\nSaindo do programa...");
                    return;
                default:
                    Console.WriteLine("\nOpção inválida! Tente novamente.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}