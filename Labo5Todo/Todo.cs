using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5Todo
{
    internal class Todo<T> where T : IComparable
    {
        static private readonly int INCRÉMENT = 5;
        public T[] appels;
        private int nbAppels;
        private int iDébut;
        private int iFin;
        public Todo()
        {
            appels = new T[INCRÉMENT];
            nbAppels = 0;
            iDébut = -1;
            iFin = -1;
        }
        public bool EstVide()
        {
            return nbAppels == 0;
        }
        public void Ajoute(T appel)
        {
            if (!this.Contient(appel))
            {
                if (nbAppels >= appels.Length)
                {
                    T[] nvAppels = new T[appels.Length + INCRÉMENT];
                    int iAppel = iDébut;
                    for (int i = 0; i < nbAppels; i++)
                    {
                        if (iAppel >= this.appels.Length || iAppel == -1) iAppel = 0;
                        nvAppels[i] = appels[iAppel];
                        iAppel++;
                    }
                    appels = nvAppels;
                    this.iDébut = 0;
                    this.iFin = nbAppels - 1;
                }
                this.iFin++;
                if (this.iFin >= this.appels.Length) iFin = 0;
                if(this.iDébut == -1) this.iDébut++;
                appels[this.iFin] = appel;
                nbAppels++;
            }
        }
        // Précondition : on n'appelle AppelLu que
        // dans le cas où le Todo n'est pas vide !
        public T AppelLu()
        {
            T résultat = this.appels[iDébut];
            nbAppels--;
            iDébut++;
            if (iDébut >= this.appels.Length) this.iDébut = 0;
            if(nbAppels== 0) iDébut = -1;
            return résultat;
        }
        public bool Contient(T appel)
        {
            foreach(T t in appels)
            {
                if(appel.CompareTo(t) == 0)
                {
                    return true;
                }
            }
            //return Array.IndexOf(appels, appel) != -1;
            return false;
        }
    }
}
