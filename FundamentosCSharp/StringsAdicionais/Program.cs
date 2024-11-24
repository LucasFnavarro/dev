namespace StringsAdicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Esse texto é um teste";

            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto.ToUpper());
            Console.WriteLine(texto.Insert(5, "AQUIII "));
            Console.WriteLine(texto.Remove(5, 5));
            Console.WriteLine(texto.Length);

            // Manipulando strings
            Console.WriteLine(texto.Replace("e", "X")); // troca todos os "e" por X
            Console.WriteLine(texto.Replace("xxxxxx", "X"));

            var divisao = texto.Split(" ");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);
            Console.WriteLine(divisao[4]);

            Console.WriteLine("-------------------------");
            Console.WriteLine(texto.Substring(5, 5));
            Console.WriteLine("-------------------------");

            Console.WriteLine(texto.Trim());

            Console.WriteLine(texto.Substring(5, texto.LastIndexOf("o") - 5));
        }
    }
}