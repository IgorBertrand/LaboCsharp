using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5ServicesSecrets
{
    internal class Personne
    {
        private int age;
        private Identite id;
        public Personne(Identite id, int age)
        {
            this.age = age;
            this.id = id;
        }
        public int Age
        {
            get { return age; }
        }
        public Identite Id
        {
            get { return id; }
        }
        public override string ToString()
        {
            return id.Prenom + ", " + id.Nom + " (" + age + ")";
        }
    }
}
