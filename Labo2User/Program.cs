namespace Labo2User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Herbert", "12345", new DateTime(2017, 10, 23));
            User user2 = new User("Corina", "GordonForever");
            User user3 = new User("Killa", "Zebiii", 20131012);
            User user4 = new User("Reshala", "Tsuka", 20000603);
            //Console.WriteLine(user2);
            //user2.JoinDate = "20121006";
            //Console.WriteLine(user2);
            //Console.WriteLine(user2.JoinDate);
            //Console.WriteLine(user3);
            Post post1 = new Post(user2, "Nique zebi");
            Post post2 = new Post(user2, "Go tarkov");
            Post post3 = new Post(user2, "Jpp j'ai envie de tarkov");
            Post post4 = new Post(user4, "Je vous fume au dorms");

            //post2.AddLike(user3);
            //post2.AddLike(user1);
            //post2.RemoveLike(user1);

            post4.AddLike(user1, user2, user3, user4 );

            //Console.WriteLine(post1);
            //Console.WriteLine(post2);
            //Console.WriteLine(post3);
            //Console.WriteLine(post4);

            User u = new User("Mélusine", "12345");
            // 0 post, 0 space, 0 digit
            Console.WriteLine(u);
            Post p1 = new Post(u, "Un deux trois");
            // 1 post, 2 spaces, 0 digit
            Console.WriteLine(u);
            Post p2 = new Post(u, "456");
            // 2 posts, 2 spaces, 3 digits
            Console.WriteLine(u);
            Post p3 = new Post(u, "7 8 neuf !");
            // 3 posts, 5 spaces, 5 digits
            Console.WriteLine(u);
        }
        static void AssertBool(string test, bool expected, bool observed)
        {
            Console.WriteLine("Test: " + test);
            Console.WriteLine("Expected: " + expected + ", observed: " + observed);
            Console.WriteLine(expected == observed ? "Ok!" : "KO !!!");
            Console.WriteLine();
        }
        static void TestValidLogin()
        {
            AssertBool("Herbert", true, ForumUtils.ValidLogin("Herbert"));
            AssertBool("empty string", false, ForumUtils.ValidLogin(""));
            AssertBool("fart", false, ForumUtils.ValidLogin("fart"));
            AssertBool("FART", false, ForumUtils.ValidLogin("FART"));
            AssertBool("FaRt", false, ForumUtils.ValidLogin("FaRt"));
        }

    }
}