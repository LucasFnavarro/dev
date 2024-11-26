using System;
using System.Collections.Generic;

namespace Treinando
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<string> alunos = new List<string> {"Lucas", "Gael", "Ana Julia", "Maria Clara"};
            Random random = new Random();
            int sortearUmAluno = random.Next(alunos.Count);
            Console.WriteLine($"Aluno sorteado foi: {alunos[sortearUmAluno]}");

            int[] num = new int[9] { 10, 20, 30, 40, 50, 60, 80, 90, 100 };
            Random random = new Random();
            int sortearUmNumero = random.Next(num.Length);
            System.Console.WriteLine($"Posição: {sortearUmNumero}");
            System.Console.WriteLine(num[sortearUmNumero]);
            */

            Console.Write("Informa a quantidade de alunos: ");
            int numeroDeAlunos = int.Parse(Console.ReadLine());

            for (var i = 0; i <= numeroDeAlunos; i++)
            {
                Console.Write($"Informe a nota do aluno {i}: ");
                double nota = double.Parse(Console.ReadLine());
             
             
            }




        }
    }
}