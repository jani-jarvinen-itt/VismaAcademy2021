using System;
using System.IO;
using System.Text;

namespace FileStreamDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiedostoNimi = @"C:\VismaAcademy\Git\DotNet\Loki.txt";

            string data = "Hei, maailma!";
            string kellonaika = DateTime.Now.ToString();

            // string merkintä = kellonaika + ": " + data + "\r\n";
            string merkintä = $"{kellonaika}: {data}\r\n";

            
             FileStream stream = new FileStream(tiedostoNimi,
                 FileMode.Append, FileAccess.Write);
             byte[] tavut = Encoding.UTF8.GetBytes(merkintä);
             stream.Write(tavut, 0, tavut.Length);

             // stream.Flush();   <-- Close()-metodi tekee tämän
             stream.Close();
             stream.Dispose();
            

            /*
            using (FileStream stream = new FileStream(tiedostoNimi,
                 FileMode.Append, FileAccess.Write))
             {
                 byte[] tavut = Encoding.UTF8.GetBytes(merkintä);
                 stream.Write(tavut, 0, tavut.Length);
             }
            */

            using FileStream stream = new FileStream(tiedostoNimi,
                FileMode.Append, FileAccess.Write);
            byte[] tavut = Encoding.UTF8.GetBytes(merkintä);
            stream.Write(tavut, 0, tavut.Length);

            Console.WriteLine($"Kirjoitettu tiedostoon {tavut.Length} tavua.");
        }

        /*
        static void Testi()
        {
            string muuttuja = "ABCD";
            int[] luvut = { 1, 2, 3, 4, 5 };

            StringBuilder teksti = new();

            // ...
        }
        */
    }
}
