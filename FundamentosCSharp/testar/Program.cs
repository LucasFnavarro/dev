using System;

namespace testar
{
    class Program
    {
        static void Main(string[] args)
        {
            var mouse = new Product(1, "Mouse Redragon gamer", 199.99, EProductType.Product);
            Console.WriteLine($"ID: {mouse.Id} - Nome: {mouse.Name} - Preço: R${mouse.Price} - Tipo: {mouse.Type}");

            Product eletricista = new Product(2, "Manutenção Elétrica", 699.75, EProductType.Service);
            Console.WriteLine($"ID: {eletricista.Id} - Nome: {eletricista.Name} - Preço: R${eletricista.Price} - Tipo: {eletricista.Type}");
        }

        struct Product
        {
            // Método construtor
            public Product(int id, string name, double price, EProductType type)
            {
                Id = id;
                Name = name;
                Price = price;
                Type = type;
            }

            // Propriedades
            public int Id { get; set; }
            public string? Name { get; set; }
            public double Price { get; set; }
            public EProductType Type { get; set; }
        }

        // Enums
        enum EProductType
        {
            Product = 1,
            Service = 2
        }
    }
}