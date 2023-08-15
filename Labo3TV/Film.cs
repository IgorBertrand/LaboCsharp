using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3TV
{
    internal class Film : Emission
    {
        protected string type;
        public Film(string titre, int durée, string type) : base(titre, durée)
        {
            this.type = type;
        }
        public override string Présentation()
        {
            return base.Présentation() + ", " + type;
        }
    }
}
