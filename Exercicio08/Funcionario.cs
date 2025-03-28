using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_FundamentosDesenvolvimentoC.Exercicio08
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        protected decimal SalarioBase { get; set; }

        public Funcionario(string nome, string cargo, decimal salarioBase)
        {
            Nome = nome;
            Cargo = cargo;
            SalarioBase = salarioBase;
        }

        public virtual decimal CalcularSalario()
        {
            return SalarioBase;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salário: R$ {CalcularSalario():F2}\n");
        }
    }

    public class Gerente : Funcionario
    {
        public Gerente(string nome, decimal salarioBase)
            : base(nome, "Gerente", salarioBase) { }

        public override decimal CalcularSalario()
        {
            return SalarioBase * 1.2m;
        }
    }

    public class FuncionariosSalarios
    {
        public static void Executar()
        {
            Console.Clear();
            Funcionario funcionario = new Funcionario("Felipe Roberto Rocha", "Engenheiro de Software", 3000);
            funcionario.ExibirDados();

            Gerente gerente = new Gerente("Rinaldo Ferreira", 8000);
            gerente.ExibirDados();
        }
    }
}
