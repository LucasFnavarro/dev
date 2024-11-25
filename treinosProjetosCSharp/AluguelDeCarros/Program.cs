using System;

namespace AluguelDeCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            AlugarCarro();
        }

        public static void AlugarCarro()
        {
            Console.Write("Quantos dias ficou com o carro: ");
            int diasAlugado = int.Parse(Console.ReadLine());

            Console.Write("Quantos KMs rodou: ");
            double kmRodado = double.Parse(Console.ReadLine());

            Console.WriteLine("\n============== RESUMO DO ALUGUEL ==============");
            Console.WriteLine($"Você ficou {diasAlugado} dias com o carro");
            Console.WriteLine($"Percorreu {kmRodado}Kms");
            Console.WriteLine("\nRealizando calculo...");
            Thread.Sleep(2000);
            double calculoFinal = CalcularAluguelDoCarro(diasAlugado, kmRodado);
            Console.WriteLine(calculoFinal.ToString("C"));
        }

        public static double CalcularAluguelDoCarro(int diasAlugado, double kmRodado)
        {
            double calculoFinal = (diasAlugado * 60) + (kmRodado * 0.15);
            return calculoFinal;
        }
    }
}