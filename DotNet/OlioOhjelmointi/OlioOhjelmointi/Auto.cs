using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioOhjelmointi
{
    public class Auto
    {
        public string Väri { get; set; }

        public string Merkki { get; set; }

        public string Malli { get; set; }

        public int Huippunopeus { get; set; }

        public bool MoottoriKäynnissä { get; set; }

        private int Nopeus { get; set; }

        public void Käynnistä()
        {
            MoottoriKäynnissä = true;
        }

        public void Sammuta()
        {
            MoottoriKäynnissä = false;
        }

        public void Kiihdytä()
        {
            Nopeus += 5;
            if (Nopeus > Huippunopeus)
            {
                Nopeus = Huippunopeus;
            }
        }

        public void Jarruta()
        {
            Nopeus -= 5;
            if (Nopeus < 0)
            {
                Nopeus = 0;
            }
        }
    }
}
