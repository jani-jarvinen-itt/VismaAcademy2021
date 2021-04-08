using AW = DataIntegraatioHarjoitus.Database.AdventureWorks;
using NW = DataIntegraatioHarjoitus.Database.Northwind;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataIntegraatioHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aloitetaan asiakastietojen kopiointi...");

            NW.NorthwindContext northwind = new();
            List<NW.Customer> nwAsiakkaat =
                northwind.Customers.ToList();

            AW.AdventureWorksContext adventure = new();
            foreach (NW.Customer nwAsiakas in nwAsiakkaat)
            {
                Console.WriteLine($"Käsitellään asiakasta {nwAsiakas.CompanyName}.");

                string[] nimenOsat = nwAsiakas.ContactName.Split(' ');
                AW.Person henkilö = new()
                {
                    FirstName = nimenOsat[0],
                    LastName = nimenOsat[1],
                    // ...
                };
                adventure.People.Add(henkilö);

                // ...

                AW.BusinessEntity be = new()
                {
                    // BusinessEntityId = 12345                    
                };
                adventure.BusinessEntities.Add(be);
                adventure.SaveChanges();
            }

            // tallennus
            Console.WriteLine("Tallennetaan tietoja...");
            adventure.SaveChanges();
            Console.WriteLine("Tietojen tallennus onnistui!");
        }
    }
}
