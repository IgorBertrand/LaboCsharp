namespace Labo3Créature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Créature bouftou = new Créature("Bouftou", 220);
            PNJ hubert = new PNJ("Hubert", 15, "commerçants");
            Familier abu = new Familier("Abu", "un petit singe", 20);
            Familier chiot = new Familier("Boule", "Dog", 100, 10);
            Familier dragonet = new Familier("Shyvana", "Gros dragon", 500);
            Marchand Jeff = new Marchand("Jeff Bezoz");
            Jeff.AjouterCompagnon(abu);
            Jeff.AjouterCompagnon(chiot);
            Jeff.AjouterCompagnon(dragonet);
            Jeff.AfficherOffre();
            Marchand cunégonde = new Marchand("Cunégonde");
            cunégonde.AjouterCompagnon(abu);
            Mercenaire m1 = new Mercenaire("homme de main", 5);
            Mercenaire m2 = new Mercenaire("garde du corps", 12);
            Mercenaire m3 = new Mercenaire("vétéran", 20);
            cunégonde.AjouterCompagnon(m1, m2, m3);
            cunégonde.AfficherOffre();
        }
    }
}