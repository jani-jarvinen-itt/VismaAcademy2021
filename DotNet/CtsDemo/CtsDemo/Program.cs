using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualBasicKirjasto;

namespace CtsDemo
{
    public class SuperLaskin : Laskin
    {
        public int Erotus(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Laskin laskin = new Laskin();
            int summa = laskin.Summa(100, 200);

            Console.WriteLine(summa);
            Console.ReadLine();
        }
    }
}
