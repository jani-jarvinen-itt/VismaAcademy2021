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

            for (int arvausKerta = 1; arvausKerta <= 3; arvausKerta++)
            {
                Console.WriteLine("Anna arvauksesti 1-20:");
                string syöte = Console.ReadLine();
                int arvaus = int.Parse(syöte);

                if (arvaus < oikea)
                {
                    Console.WriteLine("Oikea luku on suurempi!");
                }
                else if (arvaus > oikea)
                {
                    Console.WriteLine("Oikea luku on pienempi!");
                }
                else
                {
                    Console.WriteLine("Arvasit oikein!");
                    break;
                } 
            }

            Console.WriteLine("Peli on päättynyt.");
        }
    }
}
