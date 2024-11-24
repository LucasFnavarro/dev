namespace CalculoDeDesconto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\n🥳🥳🥳Calculadora de DESCONTOS 🥳🥳🥳");

            Console.Write("Qual o PREÇO do produto: ");
            float preco = float.Parse(Console.ReadLine());

            Console.Write("Quantos % de desconto: ");
            int desconto = int.Parse(Console.ReadLine());

            float totalDesconto = (preco * desconto / 100);
            float novoPrecoProduto = preco - totalDesconto;

            Console.WriteLine($"O preço do produto é {preco}, este produto conta com {desconto}% de desconto!");
            Console.WriteLine($"O preço do desconto é de R${totalDesconto}");
            Console.WriteLine($"O novo preço vai ser R${novoPrecoProduto}");
        }
    }
}