using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corso_CSharp
{
    class Dipendente : Persona
    {
        // Espone il ruolo dipendente come tipo enumerato
        public RuoloDipendente RuoloDipendente { get; set; }
        public decimal Stipendio { get; set; }

        // Questo metodo "nasconde" il metodo PresentatiEsteso presente nella classe base.
        // Questo perché il dipendente ha uno stipendio e lo dichiara, la persona normale no.
        public new string PresentatiEsteso()
        {
            return String.Format("Mi chiamo {0} {1} e sono un dipendente. Per il piacere di tutti. E sono alto {2}. Guadagno {3} euro.", Nome, Cognome, Altezza, Stipendio);
        }
    }
}
