using System;

namespace JogoDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            // Lançamento dos dados
            int dadoUsuario1 = random.Next(1, 7);
            int dadoUsuario2 = random.Next(1, 7);
            int totalUsuario = dadoUsuario1 + dadoUsuario2;

            Console.WriteLine("Os jogadores lançou os dados ");
            Console.WriteLine($"Dado 1: {dadoUsuario1}");
            Console.WriteLine($"Dado 2: {dadoUsuario2}");
            Console.WriteLine($"Total: {totalUsuario}");

            int dadoComputador1 = random.Next(1, 7);
            int dadoComputador2 = random.Next(1, 7);
            int totalComputador = dadoComputador1 + dadoComputador2;
            
            Console.WriteLine("A máquina lançou os dados");
            Console.WriteLine($"Dado 1: {dadoComputador1}");
            Console.WriteLine($"Dado 2: {dadoComputador2}");
            Console.WriteLine($"Total: {totalComputador}");

            Console.WriteLine("\nResultado:");
            if (totalUsuario > totalComputador)
            {
                Console.WriteLine($"Os jogadores ganhou com o total {totalUsuario}");
            }else if (totalUsuario < totalComputador)
            {
                Console.WriteLine($"A máquina ganhou com o total {totalComputador}");
            }
            else
            {
                Console.WriteLine("Empate entre Jogadores x Máquina!");
            }
        }
    }
}

