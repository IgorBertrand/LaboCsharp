using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3Créature
{
    internal class Familier : PNJ, ICompagnon
    {
        private int prix;
        private int prixQuotidien;
        public Familier(string nom, string description, int prix, int prixQuotidien) : base(nom, 1, "alliés")
        {
            this.Prix = prix;
            this.Description = description;
            this.prixQuotidien = prixQuotidien;
        }
        public Familier(string nom, string description, int prix) : this(nom, description, prix, 0)
        {
        }
        public string Description { get; set; }
        public int Prix 
        {
            get
            {
                return prix;
            }
            set
            {
                if (value > 0)
                {
                    prix= value;
                }
            }
        }
        public new int Pv
        {
            get
            {
                return 1;
            }
            set
            {

            }
        }
        public int PrixAchat 
        { 
            get
            {
                return prix;
            }
        }
        public int CoûtQuotidien 
        {
            get
            {
                return prixQuotidien;
            }
        }
    }
}
