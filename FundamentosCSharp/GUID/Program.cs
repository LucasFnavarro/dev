using System;

namespace GUID
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var id = Guid.NewGuid();
            id.ToString();
            id = new Guid("3e6e79a2-1b8d-4b91-9329-f112fc85a919");
            Console.WriteLine(id.ToString().Substring(0, 8));
            */

            var id = Guid.NewGuid();
            // id.ToString();

            Console.WriteLine(id.ToString().Substring(0, 10));
        }
    }
}