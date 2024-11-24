namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var meuArray = new int[5];
            int[] meuArray2 = new int[5];
            string[] arrayString = new string[2] { "Lucas", "Felipe" };

            var teste = new Teste[1] { new Teste() };


            // Atribuindo valor no array 
            meuArray[0] = 1;
            meuArray[1] = 2;

            Console.WriteLine(teste[0].Id);
            Console.WriteLine(meuArray[1]);
            Console.WriteLine(meuArray[2]);
            Console.WriteLine(meuArray[3]);
            Console.WriteLine(meuArray[4]);

            int[] meuArray3 = new int[5] { 1, 2, 3, 4, 5 };

            // foreach (int array in meuArray)
            // {
            //     Console.WriteLine(array);
            // }

            Console.WriteLine(meuArray3.Length);

            for (int index = 0; index < meuArray3.Length; index++)
            {
                // Console.WriteLine(item); // Acessa os index do array = 0, 1, 2, 3
                Console.WriteLine(meuArray3[index]); // Acessa o item (elemento)
            }
        }

        struct Teste
        {
            public int Id { get; set; }
        }
    }
}