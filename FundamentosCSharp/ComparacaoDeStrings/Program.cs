namespace ComparacaoDeStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            // Comparações de STRINGS
            var texto = "Esse texto é um teste";
            Console.WriteLine(texto.Contains("teste")); // True
            Console.WriteLine(texto.Contains("Teste")); // False
            Console.WriteLine(texto.Contains("esse", StringComparison.OrdinalIgnoreCase)); // Ignora o case sensitive
            Console.WriteLine(texto.CompareTo("Testando"));

            // StartsWith e EndsWith

            // StartsWith
            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("este"));
            Console.WriteLine(texto.StartsWith("texto"));

            // EndsWith
            Console.WriteLine(texto.EndsWith("teste"));
            Console.WriteLine(texto.EndsWith("Teste", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.EndsWith("umm"));


            var textoIgual = texto.Equals("Este texto é um testess");

            if (textoIgual)
            {
                Console.WriteLine("Os textos são iguais");
            }
            else
            {
                Console.WriteLine("Não são iguais");
            }
        }
    }
}