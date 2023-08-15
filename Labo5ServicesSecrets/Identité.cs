using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5ServicesSecrets
{
    internal class Identite
    {
        private string nom;
        private string prenom;
        public Identite(string prenom, string nom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }
        public string Nom
        {
            get { return this.nom; }
        }
        public string Prenom 
        {
            get { return this.prenom; }
        }
    }
}
