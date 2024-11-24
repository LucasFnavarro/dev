using System;
using System.Collections.Generic;

namespace Listas
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var livro = new Produto("Game of Throne", 49.9);

            var carrinho = new List<Produto>();

        }
    }
}