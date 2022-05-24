using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corso_CSharp.Attributi
{
    class Esempi
    {
        [Obsolete("Don't use OldMethod, use NewMethod instead", true)]
        public string OldMethod()
        {
            return "Metodo da non utilizzare più";
        }

        public string NewMethod()
        {
            return "Metodo da utilizzare al posto di OldMethod()";
        }
    }
}
