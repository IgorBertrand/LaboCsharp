using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3Créature
{
    internal class Créature
    {
        private string nom;
        private int pv;
        private int pvMax;
        public Créature(string nom, int pv, int pvMax)
        {
            this.Nom = nom;
            this.PvMax = pvMax;
            this.Pv = pv;
        }
        public Créature(string nom, int pvMax) : this(nom, pvMax, pvMax)
        {
        }
        public string Nom
        {
            get 
            { 
                return nom == null || nom == "" ? "<aucun nom>" : nom; 
            }
            set 
            {
                nom = value; 
            }
        }
        public int Pv
        {
            get 
            { 
                return pv; 
            }
            set 
            { 
                pv = value;
                if(pv > pvMax) pv = pvMax;
                if(pv < 0) pv = 0;
            }
        }
        public int PvMax
        {
            get 
            { 
                return pvMax; 
            }
            set
            {
                if (value <= 1) pvMax = 1;
                else pvMax= value;
            }
        }
        public double PourcentsPV
        {
            get
            {
                return ((double)pv / (double)pvMax) * 100.0;
            }
        }
        public string État
        {
            get
            {
                return this.Nom + " (" + this.Pv + "/" + this.PvMax + " : " + this.PourcentsPV.ToString("F2") + "%)" + (this.Pv <= 0 ? " - MORT" : "");
            }
        }
    }
}
