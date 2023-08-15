using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1Player
{
    internal class Map
    {
        private string name;
        private int verticalSize;
        private int horizontalSize;
        private bool authorizedInCompetition;
        public Map(string name, int verticalSize, int horizontalSize, bool authorizedInCompetition) 
        {
            this.name = name;
            this.verticalSize = verticalSize;
            this.horizontalSize = horizontalSize;
            this.authorizedInCompetition = authorizedInCompetition;
        }
        public Map(string name, int verticalSize, int horizontalSize) : this(name, verticalSize, horizontalSize, true)
        {
        }
        public Map(string name, int size, bool authorizedInCompetition) : this(name, size, size, authorizedInCompetition)
        {
        }
        public string GetName()
        {
            return this.name;
        }
        public int Surface()
        {
            return this.verticalSize * this.horizontalSize;
        }
        public override string ToString()
        {
            return this.GetName() + "(" + this.verticalSize + "x" + this.horizontalSize + ")";
        }
        public void Description()
        {
            Console.WriteLine(this.GetName() + "(" + this.verticalSize + "x" + this.horizontalSize + " surface " + this.Surface() + " cases)");
            if (this.authorizedInCompetition)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine(this.authorizedInCompetition ? "Utilisable en compétition" : "Pas utilisable");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
