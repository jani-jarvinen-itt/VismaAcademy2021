using System;
using System.Globalization;

namespace Kulttuurit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Syötä päivämäärä:");
            string syöte = Console.ReadLine();

            CultureInfo enUs = new CultureInfo("en-US");
            DateTime pvm = DateTime.Parse(syöte, enUs);
            Console.WriteLine(pvm);
            Console.WriteLine(pvm.ToString(enUs));
        }
    }
}
