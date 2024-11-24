namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Fatorial de um número
            Peça ao usuário um número e calcule o fatorial dele (exemplo: fatorial de 5 é 5 * 4 * 3 * 2 * 1 = 120)
            */

            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            int fatorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine($"\n O fatorial de {numero} é {fatorial}");
        }
    }
}