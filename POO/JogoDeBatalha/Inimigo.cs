using System;

namespace JogoDeBatalha
{
    class Inimigo : Personagem
    {
        public Inimigo(string nome, int vida, int ataque, int defesa)
        : base(nome, vida, ataque, defesa) { }

        public override void PoderEspecial()
        {
            Console.WriteLine($"\n{Nome} aumenta sua defesa em 10!");
            Defesa += 10;
        }
    }
}