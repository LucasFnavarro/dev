namespace SorteaAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] alunos = { "Lucas", "Felipe", "João", "Marco Aurelio", "Renato" };

            List<string> alunos = new List<string> {  "Lucas", "Felipe", "João", "Marco Aurelio", "Renato" };
            
            Random random = new Random();

            int indiceSorteado = random.Next(alunos.Count);

            string itemSorteado = alunos[indiceSorteado];

            Console.WriteLine(indiceSorteado);
            Console.WriteLine($"Aluno sorteado foi {itemSorteado}");
        }
    }
}

