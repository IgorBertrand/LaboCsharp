using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3Créature
{
    internal class PNJ : Créature
    {
        public PNJ(string nom, int pv, int pvMax, string faction) : base(nom, pv, pvMax)
        {
            this.Faction = faction;
        }
        public PNJ(string nom, int pvMax, string faction) : base(nom, pvMax)
        {
            this.Faction = faction;
        }
        public string Faction { get; set; }

    }
}
