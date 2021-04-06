using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace TodoTilasto
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Aloitetaan JSON-datan lataaminen.");
            HttpClient client = new();

            // haetaan web-palvelusta JSON-data
            const string Url = "https://jsonplaceholder.typicode.com/todos";
            string json = await client.GetStringAsync(Url);
            Console.WriteLine($"Luetaan {json.Length} merkkiä dataa.");

            // muunnetaan JSON-data C#-olioksi
            TodoElementti[] elementit =
                JsonSerializer.Deserialize<TodoElementti[]>(json);
            Console.WriteLine($"Luettu {elementit.Length} todo-merkintää.");

            // lasketaan completed-kentän mukaan lukumäärät per userId
            Dictionary<int, int> keskeneräiset = new();
            Dictionary<int, int> valmistuneet = new();
            foreach (TodoElementti elementti in elementit)
            {
                int käyttäjäId = elementti.userId;
                if (!keskeneräiset.ContainsKey(käyttäjäId))
                {
                    keskeneräiset[käyttäjäId] = 0;
                    valmistuneet[käyttäjäId] = 0;
                }

                bool valmis = elementti.completed;
                if (valmis)
                {
                    valmistuneet[käyttäjäId]++;
                }
                else
                {
                    keskeneräiset[käyttäjäId]++;
                }
            }

            // lasketaan prosenttiosuudet
            foreach (int käyttäjäId in valmistuneet.Keys)
            {
                int kesken = keskeneräiset[käyttäjäId];
                int valmis = valmistuneet[käyttäjäId];
                int yhteensä = kesken + valmis;

                float valmiusaste = (float)valmis / (float)yhteensä;
                Console.WriteLine($"Käyttäjä-id {käyttäjäId}: " +
                    $"{valmiusaste * 100:F0} % valmis.");
            }
        }
    }
}
