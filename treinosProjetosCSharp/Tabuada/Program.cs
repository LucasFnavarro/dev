namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            /*
            Tabuada
            Peça ao usuário um número e exiba a tabuada desse número de 1 a 10.
            */

            Console.Clear();
            Console.WriteLine("\n=-=-=-=-=-=-=-=-=- Tabuada em C# =-=-=-=-=-=-=-=-=-\n");

            Console.WriteLine("Digite um número: ");
            int valorDoUsuario = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{valorDoUsuario} x {i} = {valorDoUsuario * i}");
            }
        }
    }
}