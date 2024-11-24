using System;

namespace FundamentosDaLinguagem
{
    class Program
    {
        static void Main(string[] args)
        {
            // CSharp não aceita métodos dentro de métodos => funções.
            MeuMetodo();

            string nome = RetornaNome("Lucas", "Navarro");
            Console.WriteLine(nome);
        }

        static void MeuMetodo()
        {
            Console.WriteLine("c# .NET é muito legal!!! 🥳");
        }

        static string RetornaNome(string nome, string sobrenome, int idade = 0, bool teste = false, double novo = 33.42)
        {
            return nome + " " + sobrenome + "tem " + idade.ToString();
        }
    }
}