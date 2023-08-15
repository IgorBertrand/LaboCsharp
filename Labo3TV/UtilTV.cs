using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3TV
{
    internal static class UtilTV
    {
        public static void AfficheProgramme(params Emission[] emissions)
        {
            foreach(Emission emission in emissions)
            {
                Console.WriteLine(emission.Présentation());
            }
        }
        public static void PrésenteDA(params DessinAnimé[] das)
        {
            foreach (DessinAnimé da in das)
                Console.WriteLine(da.Présentation());
        }

    }
}
