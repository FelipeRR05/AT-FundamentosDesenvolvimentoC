using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_FundamentosDesenvolvimentoC.Exercicio07
{
    public class ContaBancaria
    {
        public string Titular { get; private set; }
        private decimal saldo;

        public ContaBancaria(string titular, decimal saldoInicial = 0)
        {
            Titular = titular;
            saldo = saldoInicial >= 0 ? saldoInicial : 0;
        }

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("\nO valor do depósito deve ser positivo!");
                return;
            }
            saldo += valor;
            Console.WriteLine($"\nDepósito de R$ {valor:F2} realizado com sucesso!");
        }

        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("\nO valor do saque deve ser positivo!");
                return;
            }

            if (valor > saldo)
            {
                Console.WriteLine("\nSaldo insuficiente para realizar o saque!");
                return;
            }

            saldo -= valor;
            Console.WriteLine($"\nSaque de R$ {valor:F2} realizado com sucesso!");
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"\nSaldo atual: R$ {saldo:F2}");
        }
    }

    public class TransacoesBancarias
    {
        public static void Executar()
        {
            Console.Clear();
            Console.Write("Digite o nome do titular da conta: ");
            string nomeTitular = Console.ReadLine();

            ContaBancaria conta = new ContaBancaria(nomeTitular);

            Console.WriteLine($"\nTitular: {conta.Titular}");

            conta.Depositar(500);
            conta.ExibirSaldo();

            Console.WriteLine("\nTentativa de saque: R$ 700,00");
            conta.Sacar(700);

            conta.Sacar(200);
            conta.ExibirSaldo();
        }
    }
}