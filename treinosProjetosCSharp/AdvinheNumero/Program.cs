namespace AdvinheNumero
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int numero_sorteado = random.Next(1, 10);

            Console.WriteLine("-=-=-=-=-=- ADVINHE O NÚMERO DE 0 A 100 -=-=-=-=-=-");
            int chute = 0;

            while (numero_sorteado != chute)
            {
                chute = int.Parse(Console.ReadLine());

                if (chute < numero_sorteado)
                {
                    Console.WriteLine("Chute menor que o número sorteado");
                }
                else if (chute > numero_sorteado)
                {
                    Console.WriteLine("Chute maior que o número sorteado");
                }
                else
                {
                    Console.WriteLine($"Parabénsss você acertou, você chutou {chute} e era {numero_sorteado}");
                }
            }
























            // Random random = new Random();
            // int numeroSorteado = random.Next(1, 10);
            // int chute = 0;

            // Console.WriteLine("Adivinhe o número entre 0 e 100");

            // while (numeroSorteado != chute)
            // {
            //     int.Parse(Console.ReadLine());

            //     if (numeroSorteado < chute)
            //     {
            //         Console.WriteLine("O número que você chutou é menor que o número sorteado!");
            //     }
            //     else if (numeroSorteado > chute)
            //     {
            //         Console.WriteLine("O número que você chutou é maior que o número sorteado!");
            //     }
            //     else
            //     {
            //         Console.WriteLine($"O número escolhido é {numeroSorteado}!!! Você acertou... 🥳🥳🥳");
            //     }
            // }

        }
    }
}