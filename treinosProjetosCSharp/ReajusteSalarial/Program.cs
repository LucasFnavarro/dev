namespace ReajusteSalarial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Reajuste Salarial de funcionários 👨‍🔧");

            Console.Write("Qual o salario atual do funcionário: ");
            float salarioDoFuncionario = float.Parse(Console.ReadLine());

            Console.Write("Quantos % de reajuste ele vai receber: ");
            int porcentagemDeReajuste = int.Parse(Console.ReadLine());

            float valorDoReajusteSalarial = salarioDoFuncionario + (salarioDoFuncionario * porcentagemDeReajuste / 100);

            // float novoSalarioReajustado = salarioDoFuncionario + valorDoReajusteSalarial;

            Console.WriteLine("\n -=-=-=-=-=-=-=-= RESUMO DO FUNCINÁRIO -=-=-=-=-=-=-=-=");

            Console.WriteLine($"Salário antigo: R${salarioDoFuncionario}");
            Console.WriteLine($"Porcetagem do reajuste: {porcentagemDeReajuste}%");
            Console.WriteLine($"Valor do reajuste: R${valorDoReajusteSalarial}");
        }
    }
}