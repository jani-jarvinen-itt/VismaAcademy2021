using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioOhjelmointi
{
    public class Tilaus
    {
        public Asiakas Tilaaja { get; set; }

        public Tuote[] TilatutTuotteet { get; set; }
    }
}
