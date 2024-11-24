namespace ConversorDeMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("=-=-=-=-= VAMOS PINTAR SUA PAREDE? =-=-=-=-=");

            Console.Write("Digite a largura da parede: ");
            float largura = float.Parse(Console.ReadLine());

            Console.Write("Digite a altura da parede: ");
            float altura = float.Parse(Console.ReadLine());

            float area = largura * altura;
            float litrosDeTinta = area / 2;

            Console.WriteLine($"Sua parede tem a dimensão de {largura} x {altura} e sua área é de {area}m²");
            Console.WriteLine($"Para pintar essa parede precisará de {litrosDeTinta}L");

        }
    }
}