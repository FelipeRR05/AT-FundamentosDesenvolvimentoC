using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_FundamentosDesenvolvimentoC.Exercicio12
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }
    }

    public abstract class ContatoFormatter
    {
        public abstract void ExibirContatos(List<Contato> contatos);
    }

    public class MarkdownFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine("\n## Lista de Contatos");
            foreach (var contato in contatos)
            {
                Console.WriteLine($"- **Nome:** {contato.Nome}");
                Console.WriteLine($"- Telefone: {contato.Telefone}");
                Console.WriteLine($"- Email: {contato.Email}");
            }
        }
    }

    public class TabelaFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("| Nome | Telefone | Email |");
            Console.WriteLine("----------------------------------------");
            foreach (var contato in contatos)
            {
                Console.WriteLine($"| {contato.Nome} | {contato.Telefone} | {contato.Email} |");
            }
            Console.WriteLine("----------------------------------------");
        }
    }

    public class RawTextFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine();
            foreach (var contato in contatos)
            {
                Console.WriteLine($"Nome: {contato.Nome} | Telefone: {contato.Telefone} | Email: {contato.Email}");
            }
        }
    }

    public class Contatos2
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

            var contatos = new List<Contato>();
            string[] linhas = File.ReadAllLines(caminhoArquivo);

            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(',');
                contatos.Add(new Contato(dados[0], dados[1], dados[2]));
            }

            Console.WriteLine("\nEscolha o formato de exibição:");
            Console.WriteLine("1 - Markdown");
            Console.WriteLine("2 - Tabela");
            Console.WriteLine("3 - Texto Puro");
            Console.Write("\nDigite a opção desejada: ");
            string opcao = Console.ReadLine();
            
            ContatoFormatter formatter;
            switch (opcao)
            {
                case "1":
                    formatter = new MarkdownFormatter();
                    break;
                case "2":
                    formatter = new TabelaFormatter();
                    break;
                case "3":
                    formatter = new RawTextFormatter();
                    break;
                default:
                    Console.WriteLine("Opção inválida, exibindo no formato padrão (Texto Puro).");
                    formatter = new RawTextFormatter();
                    break;
            }

            if (formatter != null)
            {
                formatter.ExibirContatos(contatos);
            }
            else
            {
                Console.WriteLine("Opção inválida, exibindo no formato padrão (Texto Puro).");
                new RawTextFormatter().ExibirContatos(contatos);
            }
        }
    }
}