using System;

namespace ArvaaLukuPeli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa peliin!");
            Random random = new Random();
            int oikea = random.Next(1, 21);
            Console.WriteLine(oikea);

            Console.WriteLine("Peli on päättynyt.");
        }
    }
}
