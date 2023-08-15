using System.Text;
using System.Text.RegularExpressions;

namespace Labo6LINQLambdas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Des tableaux
            int[] nombres = { 7, 9, 13, 16, 21, 22, 29, 36, 44, 47, 51, 55, 64, 71, 77, 81, 99 };
            char[] voyelles = { 'a', 'e', 'i', 'o', 'u', 'y' };
            int[] intVoyelles = new int[6];
            // Une collection simple via List
            List<string> prénoms = new List<string>();
            string[] prénomsTmp = { "Anatole", "Bergamote", "Cunégonde", "Doriphore",
                                    "Fernande", "Gustave", "Hermione", "Isidore", "Mathilde", "Ophélie",
                                    "Quasimodo", "Raistlin", "Wilfred", "Zénobe" };
            foreach (string prénom in prénomsTmp)
                prénoms.Add(prénom);
            // Un tableau associatif via Dictionary
            Dictionary<int, List<string>> dico = new Dictionary<int, List<string>>();
            string[] nombresFr = { "un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf", "dix" };
            string[] nombresEn = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            for (int i = 1; i < 10; i++)
            {
                dico[i] = new List<string>();
                dico[i].Add(nombresFr[i - 1]);
                dico[i].Add(nombresEn[i - 1]);
            }
            Console.WriteLine(Affichage(prénoms));
            Console.WriteLine(Affichage(prénoms.Where(s => s.Length == 7)));
            Console.WriteLine(Affichage(prénoms.Where(s => s.Contains("i"))));
            Console.WriteLine(Affichage(prénoms.Where(s => s.CompareTo("C") < 0 || s.CompareTo("Sharp") > 0)));
            Console.WriteLine(Affichage(prénoms.Where(s => s.Last().CompareTo('e') != 0)));
            Console.WriteLine(Affichage(prénoms.Select(s => s.ToUpper())));
            Console.WriteLine(Affichage(prénoms.Select(s => s.Substring(1))));
            for(int i = 0; i < voyelles.Length; i++)
            {
                intVoyelles[i] = (int)voyelles[i];
            }
            Console.WriteLine(Affichage(intVoyelles));
            Console.WriteLine(Affichage(nombres));
            Console.WriteLine(Affichage(nombres.Where(n => n % 2 == 0)));
            Console.WriteLine(Affichage(nombres.SkipWhile(n => n % 11 != 0)));
            Console.WriteLine(Affichage(nombres.Select(n => n.ToString().Last().ToString())));
            Console.WriteLine(Affichage(nombres.Select(n => n.ToString().Last().ToString()).Distinct()));
            Regex rDeuxLettres = new Regex("(\\w)\\w+\\1");
            Console.WriteLine(Affichage(prénoms.Where(s => rDeuxLettres.IsMatch(s))));
            Console.WriteLine(Affichage(dico));
            Console.WriteLine(prénoms.Count(s => s.Length == 7));
            Console.WriteLine(prénoms.All(s => s.Length >= 7));
            //Console.WriteLine(prénoms.All(s => s.Length >= 7));
            Console.WriteLine(prénoms.Select(s => s.Length).Average());
            Console.WriteLine(nombres.Where(n => n % 2 != 0).Average());
            Console.WriteLine(prénoms.Select(s => s.Length).Max());
            Console.WriteLine(Affichage(dico.Where(d => d.Value[0].Length == 3 || d.Value[1].Length == 3).Select(d => d.Key)));
            Console.WriteLine(Affichage(dico.Where(d => d.Value[0].Length == d.Value[1].Length).Select(d => d.Key)));
            Console.WriteLine(Affichage(dico.Select(d => d.Value[0].Length + d.Value[1].Length)));

        }
        static string Affichage(IEnumerable<string> valeurs)
        {
            StringBuilder res = new StringBuilder();
            res.Append("[");
            bool premier = true;
            foreach (string val in valeurs)
            {
                if (!premier)
                    res.Append(", ");
                else
                    premier = false;
                res.Append(val);
            }
            res.Append("]");
            return res.ToString();
        }
        static string Affichage(IEnumerable<int> valeurs)
        {
            return Affichage(valeurs.Select(valeur => $"{valeur}"));
        }
        static string Affichage(Dictionary<int, List<string>> collection)
        {
            return Affichage(collection.Keys.Select(valeur => $"{valeur}->[{collection[valeur][0]}, {collection[valeur][1]}]"));
        }
    }
}