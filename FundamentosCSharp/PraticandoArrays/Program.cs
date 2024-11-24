namespace PraticandoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] meuArray = new int[5] { 1, 2, 3, 4, 5 };
            string[] arrayNomes = new string[3] { "Ruby", "Nuff", "Marley" };

            var funcionarios = new Funcionarios[2];
            funcionarios[0] = new Funcionarios() { Id = 231, Nome = "Lucas" };
            funcionarios[1] = new Funcionarios() { Id = 235, Nome = "Aluizio" };

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine($"ID: {funcionario.Id} - Nome: {funcionario.Nome}");
            }
            
            for (int index = 0; index < arrayNomes.Length; index++)
            {
                Console.WriteLine(arrayNomes[index]); // Percorrendo os elementros dentro do array,
                                                      // e não os indices aonde estão armazenados.
            }

            // Percorrendo Arrays com ForEach()
            // foreach (var item in arrayNomes)
            // {
            //     Console.WriteLine(item);
            // }
        }
    }

    public struct Funcionarios()
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
    }
}