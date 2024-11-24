using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=-=-=-=-=-=-=-= Calculadora em C# .NET =-=-=-=-=-=-=-=\n\n");
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Escolha a opção que deseja");
            Console.WriteLine("1- Adição \n2- Subtração \n3- Multiplicação \n5- Sair");
            int opcaoMenu = int.Parse(Console.ReadLine());

            switch (opcaoMenu)
            {
                case 1: Adicao(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Adicao()
        {
            Console.Clear();
            Console.WriteLine(" ===> Soma de Adição");
            Console.WriteLine("Digite o primeiro valor: ");
            var valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            var valor2 = float.Parse(Console.ReadLine());

            float somaValores = valor1 + valor2;

            Console.WriteLine($"A soma dos valores é {valor1} + {valor2} = {somaValores}");
            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine(" ===> Soma de Subtração");
            Console.WriteLine("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float somaValores = valor1 - valor2;

            Console.WriteLine($"O resultado é {valor1} - {valor2} = {somaValores}");
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine(" ===> Soma de Multiplicação");
            Console.WriteLine("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float somaValores = valor1 * valor2;

            Console.WriteLine($"O resultado é {valor1} x {valor2} = {somaValores}");
        }

    }

}