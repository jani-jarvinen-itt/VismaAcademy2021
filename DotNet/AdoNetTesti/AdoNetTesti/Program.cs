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
            using (SqlConnection yhteys = new SqlConnection(yhteysmerkkijono))
            {
                yhteys.Open();
                Console.WriteLine("Tietokantayhteys avattu.");

                string sql = "SELECT * FROM Custmers WHERE Country = 'Finland'";
                using (SqlCommand komento = new SqlCommand(sql, yhteys)) {

                    Console.WriteLine("Suoritetaan SQL-kysely...");
                    using (SqlDataReader lukija = komento.ExecuteReader())
                    {
                        while (lukija.Read())
                        {
                            string yritys = lukija["CompanyName"].ToString();
                            Console.WriteLine(yritys);
                        }
                    }
                }
            }

            Console.WriteLine("Suoritus päättyy.");
            Console.ReadLine();
        }
    }
}
