using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioOhjelmointi
{
    public class Urheiluauto : Auto
    {
        public bool RättikattoAlhaalla { get; set; }

        public void KattoAlas()
        {
            RättikattoAlhaalla = true;
        }
    }
}
