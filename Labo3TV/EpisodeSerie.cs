using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3TV
{
    internal class EpisodeSerie : Emission
    {
        protected string titreSerie;
        protected int numeroEpisode;
        public EpisodeSerie(string titre, int duree, string titreSerie, int numeroEpisode) : base(titre, duree)
        {
            this.titreSerie = titreSerie;
            this.numeroEpisode = numeroEpisode;
        }
        public override string Présentation()
        {
            return titreSerie + " : " + base.Présentation();
        }
    }
}
