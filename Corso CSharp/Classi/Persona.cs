using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corso_CSharp
{
    class Persona : IUomo
    {
        // Variabili private. Nella proprietà definirò esplicitamente la relazione con i get e set
        private string _cognome; // Posso utilizzare un underscore come prefisso, come nel C++
        private float altezza;   // Posso utilizzare il nome senza prefisso. Quando voglio riferirmi
                                 // a questa variabile posso specificare this.altezza
        public string Cognome { get => _cognome; set => _cognome = value; }

        // Uso le proprietà definite automaticamente.
        // Il compilatore genera un codice simile al precedente.
        // La variabile interna è accessibile tramite "Nome"
        public string Nome { get; }

        // Nota: il nome non sarà impostabile da codice, solo da costruttore.
        // Il codice interno può impostare però Nome="qualcosa";

        public float Altezza
        {
            get
            {
                return altezza;
            }
            set
            {
                altezza = value;
            }
        }

        public DateTime DataNascita { get; set; }

        // Definisco tre costruttori. Il primo senza parametri, gli altri con parametri
        public Persona()
        {
            Cognome = "<non definito>";
            this.Nome = "<non definito>";
        }
        public Persona(string cognome)
        {
            this.Cognome = cognome;
            this.Nome = "<non definito (costruttore con cognome)>";
        }

        public Persona(string cognome, string nome)
        {
            Cognome = cognome;
            Nome = nome;
        }

        public Persona(string cognome, string nome, DateTime dataNascita)
        {
            _cognome = cognome;
            Nome = nome;
            DataNascita = dataNascita;
        }


        public string Presentati()
        {
            return String.Format("Mi chiamo {0} {1}. Per il piacere di tutti.", Nome, Cognome);
        }

        public string PresentatiAlternativo()
        {
            // Con questa sintassi, al posto dei segnaposto inserisco i nomi delle variabili/campi
            return $"Mi chiamo {Nome} {Cognome}. Per il piacere di tutti.";
        }

        // Notazione Lambda. Tolgo le parentesi e, alla destra del simbolo => metto il valore da ritornare
        public string PresentatiLambda => $"Mi chiamo { Nome } {Cognome}. Per il piacere di tutti.";

        public string PresentatiEsteso()
        {
            return String.Format("Mi chiamo {0} {1}. Per il piacere di tutti. E sono alto {2}.", Nome, Cognome,altezza);
        }
    }
}
