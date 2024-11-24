using System;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alunos = new string[3];
            alunos[0] = "Lucas";
            alunos[1] = "Emanuel";
            alunos[2] = "Joaquim";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = new double[4] { 9.6, 8.5, 6.8, 7.8 };

            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;

            Console.WriteLine($"A média final é: {media.ToString("F2")}");


            char[] letras = { 'A', 'r', 'r', 'a', 'y' };

            foreach(var letra in letras)
            {
                Console.WriteLine(letra);
            }
        }
    }
}