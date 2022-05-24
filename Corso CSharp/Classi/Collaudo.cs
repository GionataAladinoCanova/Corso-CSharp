using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corso_CSharp.Classi
{
    static class Collaudo
    {
        static public void Esegui()
        {
            // Ereditarietà ed interfacce.
            // Persona deve rispettare IUomo, quindi DEVE avere il metodo Presentati()
            Persona persona1 = new Persona("Gionata Aladino","Canova");

            Console.WriteLine("persona1 si presenta:");
            Console.WriteLine();
            Console.WriteLine(persona1.Presentati());

            Console.WriteLine("persona1 si presenta con il metodo esteso, quindi scrive che è un dipendente:");
            Console.WriteLine();
            Console.WriteLine(persona1.PresentatiEsteso());


            // Dipendente deriva da Persona.
            // Ha il metodo Presentati EREDITATO da Persona()
            Dipendente dipendente1 = new Dipendente();

            // Imposta il ruolo dipendente selezionandolo dal tipo enumerato
            dipendente1.RuoloDipendente = RuoloDipendente.CapoSquadra;

            Console.WriteLine("dipendente1 si presenta, con il metodo standard, quindi NON scrive che è un dipendente:");
            Console.WriteLine();
            Console.WriteLine(dipendente1.Presentati());

            Console.WriteLine("dipendente1 si presenta con il metodo esteso, quindi scrive che è un dipendente:");
            Console.WriteLine();
            Console.WriteLine(dipendente1.PresentatiEsteso());

            Console.ReadLine();
        }
    }
}
