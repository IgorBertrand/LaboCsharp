using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3Créature
{
    internal class Marchand : PNJ
    {
        private ICompagnon[] compagnonsAVendre = new ICompagnon[10];
        public Marchand(string nom) : base(nom, 10, 10, "Commerçants")
        {
            this.Nom= nom;
        }
        public void AjouterCompagnon(params ICompagnon[] compagnon)
        {
            foreach (ICompagnon compa in compagnon)
            {
                for (int iCompagnon = 0; iCompagnon < 10; iCompagnon++)
                {
                    if (compagnonsAVendre[iCompagnon] == null)
                    {
                        compagnonsAVendre[iCompagnon] = compa;
                        iCompagnon += 10;
                    }
                }
            }
        }
        public void AfficherOffre()
        {
            Console.WriteLine(Nom + " propose :");
            int iCompagnon = 1;
            foreach(ICompagnon compagnon in compagnonsAVendre)
            {
                if(compagnon != null)
                {
                    Console.WriteLine("(" + iCompagnon + ") " + compagnon.Nom + " : " + compagnon.PrixAchat + " po" + (compagnon.CoûtQuotidien > 0 ? " plus " + compagnon.CoûtQuotidien + " po par jour" : ""));
                    iCompagnon++;
                }
            }
        }
    }
}
