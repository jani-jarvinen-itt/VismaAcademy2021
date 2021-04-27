using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace AzureFunctionApp
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            int summa = 0;
            int lukum‰‰r‰ = 0;

            for (int i = 1; i <= 10; i++)
            {
                string arvo = req.Query["luku" + i];
                if (!string.IsNullOrEmpty(arvo))
                {
                    summa += int.Parse(arvo);
                    lukum‰‰r‰++;
                }
                else
                {
                    break;
                }
            }

            double keskiarvo = summa / (double)lukum‰‰r‰;
            string viesti = $"Keskiarvo on: {keskiarvo}.";
            return new OkObjectResult(viesti);

            /*
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            name = name ?? data?.name;

            string responseMessage = string.IsNullOrEmpty(name)
                ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
                : $"Hello, {name}. This HTTP triggered function executed successfully.";

            return new OkObjectResult(responseMessage);
            */
        }
    }
}
