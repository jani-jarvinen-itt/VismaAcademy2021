using AspNetWebApiDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetWebApiDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestiController : ControllerBase
    {
        [HttpGet]
        [Route("sanomoi")]
        public string Moi()
        {
            return "Moi!";
        }

        [HttpPost]
        [Route("summa/{c:int}")]
        public SummaTulokset Summa([FromBody] SummattavaLuvut luvut, int c)
        {
            // string arvo = Request.Headers["X-OmaJuttu"];

            int summa = luvut.A + luvut.B + c;
            SummaTulokset tulokset = new()
            {
                Onnistui = true,
                Summa = summa
            };

            return tulokset;
        }

        /*[HttpPut]
        [Route("kello")]*/
        [HttpPut("kello")]
        public DateTime Kellonaika()
        {
            return DateTime.Now;
        }

        [HttpDelete]
        [Route("pois")]
        public string Poista()
        {
            return "Poistettu!";
        }
    }
}
