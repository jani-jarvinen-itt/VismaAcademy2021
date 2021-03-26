using AspNetWebApiDemo.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetWebApiDemo.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AsiakkaatController : ControllerBase
    {
        [HttpGet]
        public List<Customer> KaikkiAsiakkaat()
        {
            NorthwindContext konteksti = new();
            List<Customer> asiakkaat = konteksti.Customers.ToList();
            return asiakkaat;
        }

        [HttpGet]
        [Route("maa/{maanNimi}")]
        public List<Customer> HaeAsiakkaatMaittain(string maanNimi)
        {
            NorthwindContext konteksti = new();
            List<Customer> asiakkaat = (from c in konteksti.Customers
                                        where c.Country == maanNimi
                                        select c).ToList();
            return asiakkaat;
        }
    }
}
