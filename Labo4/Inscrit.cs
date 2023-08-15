using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4
{
    internal abstract class Inscrit
    {
        public abstract string Name { get; }
        public abstract int CodePostal { get; }
        public Formation formationPrincipale { get; set; }
        public List<Formation> Formations = new List<Formation>();
        public const int NB_MAX_FORMATIONS_SUIVIES = 5;
        public Inscrit(Formation formation) 
        {
            if (formation == null) throw new Exception("Il faut une formation principale !");
            if (this.Formations.Count <= NB_MAX_FORMATIONS_SUIVIES)
            {
                if (formationPrincipale == null) this.formationPrincipale = formation;
                Formations.Add(formation);
            }
        }
        public override string ToString()
        {
            return $"{Name} ({CodePostal})";
        }
        public int FormationPrincipale
        {
            get
            {
                return formationPrincipale.Code;
            }
            set
            {
                foreach(Formation formation in Formations)
                {
                    if (formation.Code == value) formationPrincipale = formation;
                }
            }
        }
        public void AjoutFormation(Formation formation, bool principale = false)
        {
            if(Formations.Count < NB_MAX_FORMATIONS_SUIVIES)
            {
                if (!Formations.Contains(formation))
                {
                    if(formation.NbPlacesMax < formation.Inscrits.Count)
                    {
                        Formations.Add(formation);
                        if(principale)
                        {
                            FormationPrincipale= formation.Code;
                        }
                    }
                }
                else
                {
                    if (principale)
                    {
                        FormationPrincipale = formation.Code;
                    }
                }
            }
            else
            {
                if (principale)
                {
                    FormationPrincipale = formation.Code;
                }
            }
        }
        public void AjoutFormations(params Formation[] formations)
        {
            foreach(Formation form in formations)
            {
                AjoutFormation(form);
            }
        }
        public abstract double PourcRéductionBase { get; }
        public double Coût(Formation formation)
        {
            return formation.Prix * (1 + PourcRéductionBase / 100);
        }
        public double CoûtTotal()
        {
            double total = 0;
            foreach(Formation formation in Formations)
            {
                total += Coût(formation);
            }
            return total;
        }
        public string FicheInformations()
        {
            StringBuilder strInfo = new StringBuilder();
            strInfo.Append($"Inscrit : {this.ToString()}\n");
            foreach(Formation formation in Formations)
            {
                strInfo.Append(formation.ToString() + "\n");
            }
            strInfo.Append($"Total à payer : {this.CoûtTotal()}");
            return strInfo.ToString();
        }
    }
}
