using Microsoft.EntityFrameworkCore;
using NorthwindEntityDemo.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindEntityDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            NorthwindContext konteksti = new();
            await konteksti.SaveChangesAsync();

            /*var shipNameTiedot = from o in konteksti.Orders
                                 select new { o.ShipName };

            var testi = from c in konteksti.Customers.Include("Orders")
                        where c.Country == "Finland"
                        select new { c.CustomerId, c.CompanyName, c.Orders };*/

            var testi2 = from c in konteksti.Customers
                         join o in konteksti.Orders on c.CustomerId equals o.CustomerId
                         where c.Country == "Finland"
                         select new { c.CustomerId, c.CompanyName, o.ShipName };

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
