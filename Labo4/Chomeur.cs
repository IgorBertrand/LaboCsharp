using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4
{
    internal class Chomeur : Inscrit
    {
        private string nom;
        private int condePostal;
        public override string Name { get; }
        public override int CodePostal { get; }
        public override double PourcRéductionBase
        {
            get
            {
                return 100;
            }
        }
        private int NumONEM { get; set; }
        public Chomeur(Formation formationPrincipale, string nom, int codePostal, int numONEM) : base(formationPrincipale)
        {
            this.nom= nom;
            this.condePostal= codePostal;
            this.NumONEM = numONEM;
        }
    }
}
