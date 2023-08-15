using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1Player
{
    internal class Player
    {
        #region attributes
        private string firstName;
        private string lastName;
        private DateTime birthday;
        private int skillRating;
        private bool sponsored;
        public const int NB_MAX_MAPS = 5;
        private Map[] maps = new Map[5];
        #endregion

        #region constructors
        public Player(string firstName, string lastName, DateTime birthday, bool isRanked)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
            this.skillRating = isRanked ? 1 : 0;
        }
        public Player(string firstName, string lastName, DateTime birthday) : this(lastName,firstName,birthday,false)
        {
        }
        #endregion
        public string GetName()
        {
            return this.lastName + " " + this.firstName;
        }
        public string GetBirthday()
        {
            return this.birthday.Day + "/" + this.birthday.Month + "/" + this.birthday.Year;
        }
        public void SetRanked(int points)
        {
            if(!this.IsRanked())
            {
                this.skillRating = points;
            }
        }
        public bool IsRanked()
        {
            return this.skillRating != 0;
        }
        public override string ToString()
        {
            string output = "";
            output += this.GetName() + "\n";
            output += this.GetBirthday() + "\n";
            output += (this.IsRanked() ? "Ranked" : "Not ranked") + "\n";
            output += this.ListingMaps();
            return output;
        }
        public void ModifySkillRating(int nbPoints)
        {
            if (this.IsRanked())
            {
                this.SetRanked(nbPoints);
                if (this.skillRating > 5000)
                {
                    this.SetRanked(5000);
                }
                if (this.skillRating < 1)
                {
                    this.SetRanked(1);
                }
            }
        }
        public void AddMap(Map map)
        {
            if (!this.maps.Contains(map))
            {
                for (int iMap = NB_MAX_MAPS - 1; iMap > 0; iMap--)
                {
                    this.maps[iMap] = this.maps[iMap - 1];
                }
                this.maps[0] = map;
            }
            else
            {
                int iTempMap = 0;
                Map tempMap;
                for (int iMap = 0; iMap < NB_MAX_MAPS; iMap++)
                {
                    if (this.maps[iMap] == map)
                    {
                        iTempMap = iMap;
                        iMap += NB_MAX_MAPS;
                    }
                }
                for (int iMap = iTempMap; iMap > 0; iMap--)
                {
                    tempMap = this.maps[iMap];
                    this.maps[iMap] = this.maps[iMap - 1];
                    this.maps[iMap - 1] = tempMap;
                }
            }
        }
        public string ListingMaps()
        {
            string message = "";
            int iMap = 0;
            foreach(Map map in this.maps)
            {
                if (map != null)
                {
                    message+= (iMap + 1) + " - " + map.GetName();
                }
                else
                {
                    message += (iMap + 1) + " - ";
                }
                message += "\n";
                iMap++;
            }
            return message;
        }
    }
}
