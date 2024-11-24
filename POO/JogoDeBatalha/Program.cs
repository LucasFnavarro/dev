using System;

namespace JogoDeBatalha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Heroi heroi = new Heroi("Mago", 100, 25, 10);
            Inimigo inimigo = new Inimigo("Elfo", 80, 20, 5);
            
            Batalha batalha = new Batalha();
            batalha.Lutar(heroi, inimigo);
        }
    }
}