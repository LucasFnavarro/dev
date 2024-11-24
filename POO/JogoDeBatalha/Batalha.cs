using System;

namespace JogoDeBatalha
{
    public class Batalha
    {
        public void Lutar(Personagem heroi, Personagem inimigo)
        {
            Console.WriteLine($"\nInício da batalha entre {heroi.Nome} e {inimigo.Nome}!");

            while (heroi.Vida > 0 && inimigo.Vida > 0)
            {
                // Turno do Herói
                Console.WriteLine($"{heroi.Nome} ataca {inimigo.Nome}!");
                inimigo.ReceberDano(heroi.Ataque);

                if (inimigo.Vida <= 0)
                {
                    Console.WriteLine($"\n{inimigo.Nome} foi derrotado!");
                    break;
                }

                // Turno do Inimigo
                Console.WriteLine($"{inimigo.Nome} ataca {heroi.Nome}!");
                heroi.ReceberDano(inimigo.Ataque);

                if (heroi.Vida <= 0)
                {
                    Console.WriteLine($"\n{heroi.Nome} foi derrotado!");
                    break;
                }
            }
        }
    }
}