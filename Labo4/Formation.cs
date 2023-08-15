using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4
{
    internal class Formation
    {
        private List<Inscrit> inscrits = new List<Inscrit>();
        public List<Inscrit> Inscrits { get { return inscrits; } }
        public int Code { get; set; }
        public string Libellé { get; set; }
        public int NbPlacesMax { get; set; }
        public bool SponsoriséRW { get; set; }
        private int prix;
        public int Prix
        {
            get
            {
                return this.prix;
            }
            set
            {
                if(value < 100) this.prix = 100;
                else this.prix = value;
            }
        }
        public const int NB_PLACES_MAX = 25;
        public Formation(int code, string libellé, int nbPlacesMax, int prix)
        {
            this.Code = code;
            this.Libellé = libellé;
            this.NbPlacesMax = nbPlacesMax;
            this.Prix = prix;
            this.SponsoriséRW = true;
        }
        public string Informations()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Code} - {this.Libellé}{(this.SponsoriséRW ? " (RW)" : "")}");
            return sb.ToString();
        }
        public override string ToString()
        {
            return $"{this.Informations()} [{this.inscrits.Count} inscrit(s)]";
        }
    }
}
