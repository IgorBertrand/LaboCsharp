using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5Todo
{
    internal class Appel : IComparable
    {
        public string Nom { get; set; }
        public string NumeroTel { get; set; }
        public Appel(string nom, string numeroTel)
        {
            this.Nom = nom;
            this.NumeroTel = numeroTel;
        }
        public override string ToString()
        {
            return this.Nom + " (" + this.NumeroTel + ")";
        }
        public int CompareTo(Object obj)
        {
            if(obj is Appel)
            {
                Appel O = (Appel)obj;
                if (O.NumeroTel == this.NumeroTel) return 0;
                else return -1;

            }
            else
            {
                return -1;
            }
        }
    }
}
