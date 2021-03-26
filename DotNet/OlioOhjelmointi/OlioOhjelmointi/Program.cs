using System;

namespace OlioOhjelmointi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int luku = 123;
            string nimi = "Matti Möttönen";

            Auto oma = new();
            oma.Väri = "musta";
            oma.Merkki = "Toyota";
            oma.Malli = "Avensis";
            oma.Huippunopeus = 240;
            oma.Käynnistä();

            Auto naapurin = new();
            naapurin.Väri = "harmaa";
            naapurin.Merkki = "Toyota";
            naapurin.Malli = "Yaris";
            naapurin.Huippunopeus = 180;
            naapurin.Käynnistä();
            naapurin.Kiihdytä();

            Urheiluauto sportti = new();
            sportti.Väri = "punainen";
            sportti.Merkki = "Ford";
            sportti.Malli = "Mustang";
            sportti.Huippunopeus = 300;
            sportti.Käynnistä();

            sportti.KattoAlas();
            sportti.Kiihdytä();
        }
    }
}
