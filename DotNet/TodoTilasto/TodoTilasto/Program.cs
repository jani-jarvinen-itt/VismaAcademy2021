using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TodoTilasto
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Aloitetaan JSON-datan lataaminen.");
            HttpClient client = new HttpClient();

            const string Url = "https://jsonplaceholder.typicode.com/todos";
            string json = await client.GetStringAsync(Url);
            Console.WriteLine($"Luetaan {json.Length} merkkiä dataa.");
        }
    }
}
