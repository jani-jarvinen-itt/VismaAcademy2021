using System;
using System.IO;

namespace TiedostojenLukujenSumma
{
    /// <summary>
    /// Toteuttaa tekstitiedoston numeroiden summan laskennan.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Laskee tiedoston lukujen summan.
        /// </summary>
        /// <param name="args">Komentoriviparametrit. Ei käytössä.</param>
        static void Main(string[] args)
        {
            // aloitetaan tiedoston käsittely
            string tiedostoNimi = @"C:\VismaAcademy\Git\DotNet\Numerot.txt";
            int summa = 0;
            try
            {
                // luetaan tiedosto muistiin
                string[] rivit = File.ReadAllLines(tiedostoNimi);

                // käsitellään tiedoston sisältö rivit kerrallaan
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

                // tulostetaan lopullinen summa
                Console.WriteLine($"Tiedoston lukujen summa on: {summa}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Odottamaton virhe: {ex.Message}");
            }
        }
    }
}
