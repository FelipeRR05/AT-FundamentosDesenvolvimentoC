using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_FundamentosDesenvolvimentoC.Exercicio06
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Curso { get; set; }
        public double MediaNotas { get; set; }

        public Aluno(string nome, string matricula, string curso, double mediaNotas)
        {
            Nome = nome;
            Matricula = matricula;
            Curso = curso;
            MediaNotas = mediaNotas;
        }

        public void ExibirDados()
        {
            Console.Clear();
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Matrícula: {Matricula}");
            Console.WriteLine($"Curso: {Curso}");
            Console.WriteLine($"Média das Notas: {MediaNotas:F2}");
            Console.WriteLine($"Situação: {VerificarAprovacao()}");
        }

        public string VerificarAprovacao()
        {
            return MediaNotas >= 7 ? "Aprovado" : "Reprovado";
        }
    }

    class AlunoCadastrado
    {
        public static void Executar()
        {
            Aluno aluno = new Aluno("Felipe Roberto Rocha", "12345678", "Engenharia de Software", 7.5);
            aluno.ExibirDados();
        }
    }
}
