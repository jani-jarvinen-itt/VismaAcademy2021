using System;

namespace Muuttujat
{
    class Program
    {
        static void Main(string[] args)
        {
            var luku = 1234;
            Console.WriteLine(luku);

            //luku = "ABCD";
            //Console.WriteLine(luku);

            int[] taulukko = { 1, 2, 3, 4 };
            taulukko[5] = 1000;
            Console.WriteLine(taulukko);
        }
    }
}
