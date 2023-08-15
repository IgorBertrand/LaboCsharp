using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4
{
    internal static class Utilitaires
    {
        public static bool GrandNamur(int codePostal)
        {
            return codePostal >= 5000 && codePostal < 6000;
        }
        public static bool RegionWallonne(int codePostal)
        {
            return (codePostal >= 1300 && codePostal < 1500) || (codePostal >= 4000 && codePostal < 8000);
        }
    }
}
