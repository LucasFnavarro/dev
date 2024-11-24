namespace SPLIT
{
    class Progra
    {
        static void Main(string[] args)
        {
            string frase = "A rápida raposa marrom salta sobre o cão preguiçoso";

            string[] palavras = frase.Split(" ");

            foreach (var palavra in palavras)
            {
                Console.WriteLine(palavra);
            }




            // for(int i = 0; i < palavras.Length; i++)
            // {
            //     Console.WriteLine(palavras[i]);
            // }
        }
    }
}