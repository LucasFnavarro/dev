using System;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // var data = new DateTime();
            // var data = DateTime.Now;

            // var data = new DateTime(2024, 10, 12, 13, 23, 14);
            // Console.WriteLine(data);
            // Console.WriteLine(data.Year);
            // Console.WriteLine(data.Month);
            // Console.WriteLine(data.Day);
            // Console.WriteLine(data.Hour);
            // Console.WriteLine(data.Minute);
            // Console.WriteLine(data.Second);
            // Console.WriteLine(data.DayOfWeek);

            // formatando datas;
            // var data = DateTime.Now;
            // var formatada = string.Format("{0:yyyy/MM/dd hh:mm:ss ff z}", data);
            // Console.WriteLine(formatada);


            // Adicionando Valores

            DateTime? data = DateTime.Now;

            if (data.Date == DateTime.Now.Date)
            {
                Console.WriteLine("As datas são iguais!");
            }
 
            Console.WriteLine(data);

        }
    }
}