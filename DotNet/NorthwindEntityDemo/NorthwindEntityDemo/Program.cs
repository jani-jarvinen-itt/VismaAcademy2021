using NorthwindEntityDemo.Models;
using System;
using System.Linq;

namespace NorthwindEntityDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext konteksti = new();

            // LINQ-kysely
            var suomalaiset = from c in konteksti.Customers
                              where c.Country == "Finland"
                              select c;

            foreach (Customer asiakas in suomalaiset)
            {
                Console.WriteLine(asiakas.CompanyName);
            }

            /*
            int lkm = konteksti.Customers.Count();
            Console.WriteLine(lkm);
            */
        }
    }
}
