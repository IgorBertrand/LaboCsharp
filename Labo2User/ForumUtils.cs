using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2User
{
    internal static class ForumUtils
    {
        public static string[] FORBIDDEN_LOGINS = new[] { "", "fart" };
        public static bool ValidLogin(string login)
        {
            return !FORBIDDEN_LOGINS.Contains(login.ToLower());
        }
        public static int SpaceCount(string txt)
        {
            int count = 0;
            foreach(char carac in txt)
            {
                if(carac == ' ') count++;
            }
            return count;
        }
        public static int DigitCount(string txt)
        {
            int count = 0;
            foreach(char carac in txt)
            {
                if(carac >= '0' && carac <= '9') count++;
            }
            return count;
        }
        public static void Count(string txt, out int spaceCount, out int digitCount)
        {
            spaceCount = SpaceCount(txt);
            digitCount = DigitCount(txt);
        }
        public static void CountAndUpdate(string txt, ref int spaceCount, ref int digitCount)
        {
            spaceCount = SpaceCount(txt);
            digitCount = DigitCount(txt);
        }


    }
}
