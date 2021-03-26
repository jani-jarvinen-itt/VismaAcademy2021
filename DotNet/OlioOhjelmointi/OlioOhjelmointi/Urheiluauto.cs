using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioOhjelmointi
{
    public class Urheiluauto : Auto
    {
        // private new string Väri { get; set; }

        public bool RättikattoAlhaalla { get; set; }

        public void KattoAlas()
        {
            RättikattoAlhaalla = true;
        }
    }
}
