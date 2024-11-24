using System;

namespace JogoDeBatalha
{
    public class Heroi : Personagem
    {
        public Heroi(string nome, int vida, int ataque, int defesa)
        : base(nome, vida, ataque, defesa){}

        public override void PoderEspecial()
        {
             Console.WriteLine($"\n{Nome} usa uma cura e recupera 20 de vida!");
             Vida += 20;
        }
    }
}