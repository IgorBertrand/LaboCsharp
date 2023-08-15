using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3TV
{
    internal class Emission
    {
        protected string titre;
        protected int duree;
        public Emission(string titre, int duree)
        {
            this.titre = titre;
            this.duree = duree;
        }
        public virtual string Présentation()
        {
            return titre + " (" + duree +" minutes)" ;
        }
    }
}
