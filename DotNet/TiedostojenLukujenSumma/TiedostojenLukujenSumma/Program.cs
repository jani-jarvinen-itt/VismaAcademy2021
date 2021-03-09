using System;
using System.IO;

namespace TiedostojenLukujenSumma
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiedostoNimi = @"C:\VismaAcademy\Git\DotNet\Numerot.txt";
            int summa = 0;
            string[] rivit = File.ReadAllLines(tiedostoNimi);
            foreach (string rivi in rivit)
            {
                summa += int.Parse(rivi);
            }

            Console.WriteLine($"Tiedoston lukujen summa on: {summa}.");
        }
    }
}
