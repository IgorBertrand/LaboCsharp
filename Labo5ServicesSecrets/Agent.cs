using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5ServicesSecrets
{
    internal class Agent : Personne
    {
        private HashSet<Informateur> contacts = new HashSet<Informateur>();
        public Agent(Identite id, int age) : base(id, age)
        {
        }
        public void AjouteInformateur(Informateur informateur)
        {
            contacts.Add(informateur);
        }
        public bool ConntaitInformateur(Informateur informateur)
        {
            return contacts.Contains(informateur);
        }
        public override string ToString()
        {
            string message = base.ToString() + "\n";
            foreach(Informateur contact in contacts)
            {
                message+= contact.ToString();
            }
            return message;
        }
    }
}
