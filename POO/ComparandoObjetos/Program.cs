using System;

namespace ComparandoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var pessoaA = new Pessoa(1, "Lucas Felipe");
            var pessoaB = new Pessoa(1, "Lucas Felipe");

            Console.WriteLine(pessoaA.Equals(pessoaB));
        }
    }

    class Pessoa : IEquatable<Pessoa>
    {
        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string? Nome { get; set; }

        public bool Equals(Pessoa? other)
        {
            return Id == other.Id;
        }
    }


}