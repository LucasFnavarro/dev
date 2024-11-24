namespace Indices
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Este texto é um teste";

            Console.WriteLine(texto.IndexOf("é"));
            Console.WriteLine(texto.IndexOf("s")); // Pega o último s da string.
            Console.WriteLine(texto.IndexOf("Este"));
            Console.ReadKey();
        }
    }
}