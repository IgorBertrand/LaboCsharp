namespace Labo1Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestMaps();
            //Player player1 = new Player("Igor", "Bertrand", new DateTime(2000, 3, 6));
            //Player player2 = new Player("Sam", "Dieden", new DateTime(2000, 12, 11), true);
            //player1.SetRanked();
            //player2.SetRanked();
            //player1.AddMap("test1");
            //player1.AddMap("test2");
            //player1.AddMap("test3");
            //player1.AddMap("test4");
            //player1.AddMap("test5");
            //player1.AddMap("test1");
            //player1.AddMap("test5");
            //Console.WriteLine(player1.ToString());
            //Console.WriteLine(player2.ToString());
            Map mapTest = new Map("Faille de l'invocateur", 20, 30);
            mapTest.Description();
        }
        public static void AssertMaps(string expected, Player p)
        {
            Console.WriteLine("Expected answer : " + expected);
            Console.WriteLine(p.ListingMaps());
        }
        public static void TestMaps()
        {
            // Mise en place
            Player p = new Player("Indiana", "Jones", new DateTime(1899, 7, 1));
            // Test
            AssertMaps("aucune", p);
            // Mise en place
            p.AddMap("Canyon");
            // Test
            AssertMaps("Canyon", p);
            // Mise en place
            p.AddMap("Forteresse");
            p.AddMap("Forêt");
            // Test
            AssertMaps("Forêt, Forteresse, Canyon", p);

            // Mise en place
            p.AddMap("Forteresse");
            // Test
            AssertMaps("Forteresse, Forêt, Canyon", p);
            // Mise en place
            p.AddMap("Desert");
            p.AddMap("Oasis");
            // Test
            AssertMaps("Oasis, Desert, Forteresse, Forêt, Canyon", p);

            // Mise en place
            p.AddMap("Forêt");
            // Test
            AssertMaps("Forêt, Oasis, Desert, Forteresse, Canyon", p);
            // Mise en place
            p.AddMap("Caverne");
            // Test
            AssertMaps("Caverne, Forêt, Oasis, Desert, Forteresse", p);
        }

    }
}