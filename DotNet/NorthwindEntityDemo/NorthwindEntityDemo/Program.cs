using Microsoft.EntityFrameworkCore;
using NorthwindEntityDemo.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindEntityDemo
{
    class Program
    {
        static async void Main(string[] args)
        {
            NorthwindContext konteksti = new();

            await konteksti.SaveChangesAsync();

            // LINQ-kysely
            var suomalaiset = from c in konteksti.Customers.Include("Orders")
                              where c.Country == "Finland"
                              select c;

            foreach (Customer asiakas in suomalaiset)
            {
                string nimi = asiakas.CompanyName;
                int tilaustenLkm = asiakas.Orders.Count();

                Console.WriteLine($"Asiakkaalla {nimi} on {tilaustenLkm} kpl tilauksia.");

                foreach (Order tilaus in asiakas.Orders)
                {
                    Console.WriteLine($"\t - {tilaus.OrderDate}.");
                }
            }

            /*
            int lkm = konteksti.Customers.Count();
            Console.WriteLine(lkm);
            */
        }
    }
}
