using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Corso_CSharp
{
    // Qualunque classe rispetti l'interfaccia IUomo dovrà definire le proprietà Nome e Cognome
    // ed avere il metodo Presentati()
    public interface IUomo
    {
        string Cognome { get; }
        string Nome { get; }

        string Presentati();
    }
}