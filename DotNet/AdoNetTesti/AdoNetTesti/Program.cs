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
            SqlConnection yhteys = new SqlConnection(yhteysmerkkijono);
            try
            {
                yhteys.Open();
                Console.WriteLine("Tietokantayhteys avattu.");

                string sql = "SELECT * FROM Custmers WHERE Country = 'Finland'";
                SqlCommand komento = new SqlCommand(sql, yhteys);
                try
                {
                    Console.WriteLine("Suoritetaan SQL-kysely...");
                    SqlDataReader lukija = komento.ExecuteReader();
                    try
                    {
                        while (lukija.Read())
                        {
                            string yritys = lukija["CompanyName"].ToString();
                            Console.WriteLine(yritys);
                        }
                    }
                    finally
                    {
                        lukija.Close();
                    }
                }
                finally
                {
                    komento.Dispose();
                }
            }
            finally
            {
                yhteys.Close();
            }
            Console.WriteLine("Suoritus päättyy.");
            Console.ReadLine();
        }
    }
}
