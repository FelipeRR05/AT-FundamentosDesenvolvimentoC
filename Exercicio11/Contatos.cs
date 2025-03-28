using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_FundamentosDesenvolvimentoC.Exercicio11
{
    public class Contatos
    {
        private const string caminhoArquivo = "contatos.txt";

        public static void Executar()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Gerenciador de Contatos ===");
                Console.WriteLine("1 - Adicionar novo contato");
                Console.WriteLine("2 - Listar contatos cadastrados");
                Console.WriteLine("3 - Sair");
                Console.Write("\nEscolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarContato();
                        break;
                    case "2":
                        ListarContatos();
                        break;
                    case "3":
                        Console.WriteLine("Encerrando programa...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        private static void AdicionarContato()
        {
            Console.Write("\nNome: ");
            string nome = Console.ReadLine();

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            string contato = $"{nome},{telefone},{email}";

            File.AppendAllText(caminhoArquivo, contato + Environment.NewLine);
            Console.WriteLine("\nContato cadastrado com sucesso!");
        }

        private static void ListarContatos()
        {
            if (!File.Exists(caminhoArquivo) || new FileInfo(caminhoArquivo).Length == 0)
            {
                Console.WriteLine("\nNenhum contato cadastrado.");
                return;
            }

            string[] contatos = File.ReadAllLines(caminhoArquivo);

            Console.WriteLine("\nContatos cadastrados:");
            foreach (string linha in contatos)
            {
                string[] dados = linha.Split(',');
                Console.WriteLine($"Nome: {dados[0]} | Telefone: {dados[1]} | Email: {dados[2]}");
            }
        }
    }
}
