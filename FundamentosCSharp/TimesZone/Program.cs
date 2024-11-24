using System;

namespace TimesZone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var utcDate = DateTime.UtcNow;

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(utcDate);

            Console.WriteLine(utcDate.ToLocalTime());

            Console.WriteLine("\n============================\n\n");

            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");

            Console.WriteLine(timezoneAustralia);
        }
    }
}