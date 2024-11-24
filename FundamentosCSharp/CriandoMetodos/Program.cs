namespace CriandoMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // Console.WriteLine(Reajuste()); // utilizando return na funçaõ.
            // Reajuste(); // Utilizando o console.writeline direto.

            int v1 = int.Parse(Console.ReadLine());
            int v2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Resultado da soma é {Soma(v1, v2)}");
        }


        public static int Soma(int v1, int v2)
        {
            int resultado = v1 + v2;
            return v1 + v2;
        }


        public static void Soma(int v1, int v2)
        {
            int resultado = v1 + v2;
            Console.WriteLine($"A soma de {v1} + {v2} = {v1 + v2}");
        }

        static string Reajuste()
        {
            Console.WriteLine("Salario atual: ");
            int salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos % de reajuste: ");
            int reajuste = int.Parse(Console.ReadLine());

            var somaDoReajuste = salario * reajuste / 100;
            float novoSalario = salario + somaDoReajuste;
            Console.WriteLine($"O salário era de R${salario}, com {reajuste}% vai passar a ser R${novoSalario}");
            return @$"O salário era de R${salario}, com {reajuste}% vai passar a ser R${novoSalario}";
        }

    }
}