namespace Labo5Todo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region VInt
            Todo<int> todo = new Todo<int>();
            Console.WriteLine("Ajout de 111, 222, 333, 444, 555, 666");
            todo.Ajoute(111);
            todo.Ajoute(111);
            todo.Ajoute(222);
            todo.Ajoute(222);
            todo.Ajoute(333);
            todo.Ajoute(444);
            todo.Ajoute(555);
            todo.Ajoute(666);
            Console.WriteLine("Lecture : " + todo.AppelLu());
            Console.WriteLine("Lecture : " + todo.AppelLu());
            Console.WriteLine("Ajout de 999");
            todo.Ajoute(999);
            while (!todo.EstVide())
            {
                Console.WriteLine("Lecture : " + todo.AppelLu());
            }
            Console.WriteLine("Todo vide");
            #endregion
            #region VString
            //Todo<string> todo = new Todo<string>();
            //Console.WriteLine("Ajout de 111, 222, 333, 444, 555, 666");
            //todo.Ajoute("111");
            //todo.Ajoute("111");
            //todo.Ajoute("222");
            //todo.Ajoute("222");
            //todo.Ajoute("333");
            //todo.Ajoute("444");
            //todo.Ajoute("555");
            //todo.Ajoute("666");
            //Console.WriteLine("Lecture : " + todo.AppelLu());
            //Console.WriteLine("Lecture : " + todo.AppelLu());
            //Console.WriteLine("Ajout de 999");
            //todo.Ajoute("999");
            //while (!todo.EstVide())
            //{
            //    Console.WriteLine("Lecture : " + todo.AppelLu());
            //}
            //Console.WriteLine("Todo vide");
            #endregion
            #region VAppel
            //Todo<Appel> todo = new Todo<Appel>();
            //Appel a1 = new Appel("Ilove Ones", "111");
            //Appel a3bis = new Appel("Triple trois", "333");
            //Appel a2 = new Appel("Parité Forever", "222");
            //Appel a3 = new Appel("Demy Daemon", "333");
            //Appel a4 = new Appel("Poule Chicken", "444");
            //Appel a5 = new Appel("Phone Number", "555");
            //Appel a6 = new Appel("L. A. Bête", "666");
            //Appel a9 = new Appel("Triple Ponte", "999");
            //Console.WriteLine("Ajout de 111, 222, 333, 444, 555, 666");
            //todo.Ajoute(a1);
            //todo.Ajoute(a2);
            //todo.Ajoute(a3);
            //todo.Ajoute(a3bis);
            //todo.Ajoute(a4);
            //todo.Ajoute(a5);
            //todo.Ajoute(a6);
            //Console.WriteLine("Lecture : " + todo.AppelLu());
            //Console.WriteLine("Lecture : " + todo.AppelLu());
            //Console.WriteLine("Ajout de 999");
            //todo.Ajoute(a9);
            //while (!todo.EstVide())
            //{
            //    Console.WriteLine("Lecture : " + todo.AppelLu());
            //}
            //Console.WriteLine("Todo vide");
            #endregion
        }
    }
}