using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3Créature
{
    internal interface ICompagnon
    {
        int PrixAchat { get; }
        int CoûtQuotidien { get; }
        string Nom { get; }
    }
}
