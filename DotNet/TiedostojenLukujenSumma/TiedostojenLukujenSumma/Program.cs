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
            try
            {
                string[] rivit = File.ReadAllLines(tiedostoNimi);
                foreach (string rivi in rivit)
                {
                    bool onnistui = int.TryParse(rivi, out int tulos);
                    if (onnistui)
                    {
                        summa += tulos;
                    }
                    else
                    {
                        Console.WriteLine($"Virheellinen numero: {rivi}.");
                    }
                    /*
                    try
                    {
                        summa += int.Parse(rivi);
                    }
                    catch (FormatException fex)
                    {
                        Console.WriteLine($"Virheellinen numero: {rivi}.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Tuntematon virhe, ohitetaan rivi.");
                    }
                    */
                }

                Console.WriteLine($"Tiedoston lukujen summa on: {summa}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Odottamaton virhe: {ex.Message}");
            }
        }
    }
}
