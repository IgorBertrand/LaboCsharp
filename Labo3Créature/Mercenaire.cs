using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3Créature
{
    internal class Mercenaire : PNJ, ICompagnon
    {
        private int prixAchat;
        private int coûtQuotidien;
        public Mercenaire(string nom, int pvMax) : base(nom, pvMax, pvMax, "Mercenaire")
        {
            SetCoûtQuotidient();
            SetPrixAchat();
        }
        public int PrixAchat 
        {
            get
            {
                return prixAchat;
            }
        }
        public int CoûtQuotidien 
        {
            get
            {
                return coûtQuotidien;
            }
        }
        public void SetPrixAchat()
        {
            prixAchat = 7 * PvMax;
        }
        public void SetCoûtQuotidient()
        {
            if (this.PvMax <= 5)
            {
                coûtQuotidien = 25;
            }
            else
            {
                coûtQuotidien = 35;
                if (PvMax > 15)
                {
                    coûtQuotidien += 2 * (PvMax - 15);
                }
            }
        }
    }
}
