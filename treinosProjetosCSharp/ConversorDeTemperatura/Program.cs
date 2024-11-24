namespace ConversorDeTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Conversor de temperaturas de Graus Celsius para Graus Fahrenheit");

            Console.WriteLine("Digite a temperatura em Graus Celsius: ");
            int temperaturaCelsius = int.Parse(Console.ReadLine());

            int tempFahrenheit = 9 * temperaturaCelsius / 5 + 32;

            Console.WriteLine("-=-=-=-=-=-==-=-=-=-=- RESULTADO -=-=-=-=-=-==-=-=-=-=-");

            Console.WriteLine($"A temperatura em Graus Celsius é {temperaturaCelsius} ºC e em Fahrenheit é {tempFahrenheit} ºF");

        }
    }
}