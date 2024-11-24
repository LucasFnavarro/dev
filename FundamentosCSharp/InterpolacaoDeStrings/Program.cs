using System; 

namespace InterpolacaoDeStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var price = 10.2;
            // var texto = "O preço do produto é " + price + " apenas na promoção!";
            var texto = string.Format("O preço do produto é {0}, apenas na promoção {1}!", price, true);

            var texto2 = $@"O preço do produto é \n {price}";

            Console.WriteLine(texto);
        }
    }
}