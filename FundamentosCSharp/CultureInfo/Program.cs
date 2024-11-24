using System;
using System.Globalization;

namespace Cultureinfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");

            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine(string.Format("{0:D}", DateTime.Now));
        }
    }
}