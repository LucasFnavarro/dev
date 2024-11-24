using System;

namespace JogoDeBatalha
{
    public class Personagem
    {
        public string? Nome { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Defesa { get; set; }

        public Personagem(string nome, int vida, int ataque, int defesa)
        {
            Nome = nome;
            Vida = vida;
            Ataque = ataque;
            Defesa = defesa;
        }

        public void ReceberDano(int dano)
        {
            int danoRecebido = dano - Defesa;
            Vida -= danoRecebido > 0 ? danoRecebido : 0;

            Console.WriteLine($"\n{Nome} recebeu {danoRecebido} de dano. Vida restante: {Vida}");
        }

        public virtual void PoderEspecial() { }
    }
}