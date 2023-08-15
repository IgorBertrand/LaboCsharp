using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4
{
    internal class Institution
    {
        public string Name { get; set; }
        public int CodePostal { get; set; }
        public Institution(string name, int codePostal)
        {
            Name = name;
            CodePostal = codePostal;
        }

    }
}
