namespace Labo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Formation testFormation1 = new Formation(121, "Zebi", 15, 60);
            Formation testFormation2 = new Formation(122, "Fronce", 2, 175);
            Formation testFormation3 = new Formation(123, "Sah", 14, 300);
            Formation testFormation4 = new Formation(124, "Merci", 17, 420);
            Formation testFormation5 = new Formation(125, "De rien", 20, 500);
            Formation testFormation6 = new Formation(126, "Louma", 6, 150);
            Formation testFormation7 = new Formation(127, "dasfagzad", 20, 275);
            Chomeur thunus = new Chomeur(testFormation1,"Thunus",4280,669);
            Console.WriteLine(thunus.FicheInformations());
        }
    }
}