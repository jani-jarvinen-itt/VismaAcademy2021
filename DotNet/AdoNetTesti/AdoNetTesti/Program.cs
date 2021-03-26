using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetTesti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Avataan tietokantayhteys...");
            string yhteysmerkkijono = "Server=localhost\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;";
            /*using*/ SqlConnection yhteys = new SqlConnection(yhteysmerkkijono);
            yhteys.Open();
            Console.WriteLine("Tietokantayhteys avattu.");

            string sql = "SELECT CompanyName, ContactName FROM Customers WHERE Country = 'Finland'";
            /*using*/ SqlCommand komento = new SqlCommand(sql, yhteys);

            /*
            int[] luvut = {1, 2, 3, 4, 5 };
            int kolmas = luvut[2];
            */

            Console.WriteLine("Suoritetaan SQL-kysely...");
            /*using*/ SqlDataReader lukija = komento.ExecuteReader();
            while (lukija.Read())
            {
                // string yritys = lukija[1].ToString();
                string yritys = lukija["CompanyName"].ToString();
                string kontaksihenkilö = lukija["ContactName"].ToString();

                Console.WriteLine($"Yritys: {yritys}, kontakti: {kontaksihenkilö}.");
            }

            Console.WriteLine("Suoritus päättyy.");
            Console.ReadLine();
        }
    }
}
