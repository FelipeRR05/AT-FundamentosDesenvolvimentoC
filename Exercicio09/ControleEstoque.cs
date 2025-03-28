using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_FundamentosDesenvolvimentoC.Exercicio09
{
    public class ControleEstoque
    {
        private static List<string> produtos = new List<string>();
        private const string caminhoArquivo = "estoque.txt";
        private const int limiteProdutos = 5;

        public static void Executar()
        {
            CarregarProdutosDoArquivo();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Controle de Estoque:");
                Console.WriteLine("1 - Inserir Produto");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Sair");
                Console.Write("\nEscolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        InserirProduto();
                        break;
                    case "2":
                        ListarProdutos();
                        break;
                    case "3":
                        Console.WriteLine("\nSaindo...");
                        return;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        private static void InserirProduto()
        {
            if (produtos.Count >= limiteProdutos)
            {
                Console.WriteLine("\nLimite de produtos atingido!");
                return;
            }

            Console.Write("\nNome do Produto: ");
            string nome = Console.ReadLine();

            Console.Write("Quantidade em Estoque: ");
            if (!int.TryParse(Console.ReadLine(), out int quantidade) || quantidade < 0)
            {
                Console.WriteLine("Quantidade inválida.");
                return;
            }

            Console.Write("Preço Unitário: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal preco) || preco < 0)
            {
                Console.WriteLine("Preço inválido.");
                return;
            }

            string produto = $"{nome},{quantidade},{preco:F2}";
            produtos.Add(produto);
            File.AppendAllText(caminhoArquivo, produto + Environment.NewLine);

            Console.WriteLine("\nProduto cadastrado com sucesso.");
        }

        private static void ListarProdutos()
        {
            if (produtos.Count == 0)
            {
                Console.WriteLine("\nNenhum produto cadastrado.");
                return;
            }

            Console.WriteLine("\nProdutos Cadastrados:");
            foreach (var linha in produtos)
            {
                string[] dados = linha.Split(',');
                Console.WriteLine($"Produto: {dados[0]} | Quantidade: {dados[1]} | Preço: R$ {dados[2]}");
            }
        }

        private static void CarregarProdutosDoArquivo()
        {
            if (File.Exists(caminhoArquivo))
            {
                produtos.AddRange(File.ReadAllLines(caminhoArquivo));
            }
        }
    }
}
