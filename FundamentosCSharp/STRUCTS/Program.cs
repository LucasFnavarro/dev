using System;

// STRUCTS NÃO É UMA FUNÇÃO E É DIFERENTE DE CLASS
// TEM QUE ESTAR FORA DO ESCOPO DA CLASS

namespace FundamentosDaLinguagem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Product mouse = new Product();
            // var product = new Product();
            // Product Product = new Product();
            // Product.Id = 1;
            // Product.Name = "Teclado Redragon Gamer";
            // Product.Price = 199.99;
            // Console.WriteLine($"ID: {Product.Id} - Nome: {Product.Name} - Preço: {Product.Price}");

            // Utilizando método construtor
            Product mouse = new Product(1, "Mouse Gamer", 199.99, EProductType.Product);
            var manutencaoEletrica = new Product(2, "Manutenção Elétrica residencial", 500, EProductType.Service);

            // mouse.Id = 3;

            Console.WriteLine($"{mouse.Id} - {mouse.Name} - {mouse.Price} - {mouse.Type}");
            Console.WriteLine($"{manutencaoEletrica.Id} - {manutencaoEletrica.Name} - {manutencaoEletrica.Price} - {manutencaoEletrica.Type}");
        }


        struct Product
        {
            // Método Construtor ou Função Construtura            
            public Product(int id, string name, double price, EProductType type)
            {
                Id = id; // Prop. Id recebe por parametro o id;
                Name = name; // Prop. Name recebe por parametro o name;
                Price = price;   // Prop. Price recebe por parametro o price;
                Type = type;
            }

            // PROPRIEDADES
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public EProductType Type { get; set; }


            // Métodos (função)
            public double PriceInDolar(double dolar = 5.78)
            {
                // Somos obrigado a retornar algo por conta de ser um type double nosso método.
                return Price * dolar;
            }
        }

        enum EProductType
        {
            Product = 1,
            Service = 2,
        }
    }
}