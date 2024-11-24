namespace ContagemRegressiva
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Faça um programa que exiba uma contagem regressiva de 10 a 0, com uma pausa de 1 segundo entre cada número (use Thread.Sleep(1000)).
            */

            for(var i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }

        }
    }
}
