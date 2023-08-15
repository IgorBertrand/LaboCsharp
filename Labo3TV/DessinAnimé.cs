using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3TV
{
    internal class DessinAnimé : EpisodeSerie
    {
        protected int ageCible;
        public DessinAnimé(string titre, int duree, string titreSerie, int numeroEpisode, int ageCible) : base(titre, duree, titreSerie, numeroEpisode)
        {
            this.ageCible = ageCible;
        }
        public new string Présentation()
        {
            return "Enfants de " + ageCible + " ans : " + titre + " (" + titreSerie + " numéro " + numeroEpisode + ")";
        }
    }
}
