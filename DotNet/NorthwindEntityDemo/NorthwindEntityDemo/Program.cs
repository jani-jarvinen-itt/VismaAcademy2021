using Microsoft.EntityFrameworkCore;
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
            var suomalaiset = from c in konteksti.Customers.Include("Orders")
                              where c.Country == "Finland"
                              select c;

            foreach (Customer asiakas in suomalaiset)
            {
                string nimi = asiakas.CompanyName;
                int tilaustenLkm = asiakas.Orders.Count();

                Console.WriteLine($"Asiakkaalla {nimi} on {tilaustenLkm} kpl tilauksia.");
            }

            /*
            int lkm = konteksti.Customers.Count();
            Console.WriteLine(lkm);
            */
        }
    }
}
