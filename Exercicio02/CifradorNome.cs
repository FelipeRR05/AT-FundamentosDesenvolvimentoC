using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_FundamentosDesenvolvimentoC.Exercicio02
{
    public class CifradorNome
    {
        public static void Executar()
        {
            string nome = "Carlos Silva";
            string nomeCifrado = CifrarNome(nome);
            Console.Clear();
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Nome cifrado: " + nomeCifrado);
        }

        public static string CifrarNome(string nome)
        {
            char[] caracteres = nome.ToCharArray();

            for (int i = 0; i < caracteres.Length; i++)
            {
                if (char.IsLetter(caracteres[i]))
                {
                    char baseChar = char.IsUpper(caracteres[i]) ? 'A' : 'a';
                    caracteres[i] = (char)(baseChar + (caracteres[i] - baseChar + 2) % 26);
                }
            }

            return new string(caracteres);
        }
    }
}
