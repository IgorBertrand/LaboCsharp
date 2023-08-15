using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5ServicesSecrets
{
    internal class Informateur : Personne
    {
        private HashSet<string> domaines = new HashSet<string>();

        public Informateur(Identite id, int age) : base(id, age)
        {
        }
        public void AjouteDomaine(string domaine)
        {
            this.domaines.Add(domaine.ToLower());
        }
        public bool ConnaitDomaine(string domaine)
        {
            return this.domaines.Contains(domaine);
        }
        public void AfficheDomaines()
        {
            foreach(string domaine in this.domaines)
            {
                Console.WriteLine(domaine);
            }
        }
        public override string ToString()
        {
            string message = "";
            message += "- " + base.ToString() + " [";
            foreach(string domaine in domaines)
            {
                if (domaines.Last().ToLower() == domaine.ToLower()) message += domaine;
                else message += domaine + ", ";
            }
            message += "]\n";
            return message;
        }
    }
}
