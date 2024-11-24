using System;

namespace FundamentosDaLinguagem
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 100;
            // string name = num; <--- vai dar erro, ele não consegue converter implicitamente!
            string num_string = Convert.ToString(num);

            string num2 = "123";
            int num_convert = Convert.ToInt32(num2); // <--- Convert, converte em qualquer tipo de valor
                                                     // não somente STRINGS

            Console.WriteLine($"{num} - int num -> INTEIRO convertido em STRING");
            Console.WriteLine($"{num2} - string num2 -> STRING convertido em INT32");


            int inteiro = 100;
            float real = 25.5f;

            inteiro = real; // Não funciona, da erro de conversão.
            real = inteiro; // vai dar certo por conta da conversão implicita, o valo passa a ser 100.0f
            inteiro = (int)real; // Conversão Explicita.
            string valorReal = real.ToString();
            inteiro = int.Parse(valorReal);

            inteiro = Convert.ToInt32(real);

            Console.WriteLine(inteiro);
            Console.WriteLine(Convert.ToBoolean("1"));


            // MÉTODOS (FUNÇÕES)

            // Console.WriteLine(RetornaNome("Lucas"));

            MeuMetodo("Lucas - via parametro");
            Console.WriteLine(RetornaNome("Felipe meu 2 nome"));

        }

        static void MeuMetodo(string parametros)
        {
            Console.WriteLine(parametros);
        }

        static string RetornaNome(string nome)
        {
            return nome;
        }
    }
}