using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2User
{
    internal class User
    {
        private string login;
        private int password;
        private DateTime joinDate;
        private int postCount;
        public int spacesPosted;
        public int digitsPosted;
        public User(string login, string password, DateTime joinDate) 
        { 
            this.login = login;
            this.password = Encode(password);
            this.joinDate = joinDate;
            this.postCount = 0;
        }
        public User(string login, string password) : this(login, password, DateTime.Today)
        {
        }
        public User(string login, string password, int joinDate) : this(login, password)
        {
            this.JoinDate = joinDate.ToString();
        }
        public void AddPost(string message)
        {
            this.postCount++;
            int spaceCount;
            int digitCount;
            ForumUtils.Count(message, out spaceCount, out digitCount);
            this.spacesPosted += spaceCount;
            this.digitsPosted += digitCount;
        }
        public override string ToString()
        {
            string message = "";
            message += this.Login + "(password: " + this.password + "), " + this.JoinDate + " - " + this.postCount + " post" + (postCount > 1 ? "s" : "");
            message += " " + this.spacesPosted + " space" + (spacesPosted > 1 ? "s" : "");
            message += " " + this.digitsPosted + " digit" + (digitsPosted > 1 ? "s" : "");
            return message;
        }
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                if (ForumUtils.ValidLogin(value))
                    login = value;
            }

        }
        public string JoinDate
        {
            get
            {
                return this.joinDate.ToString();
            }
            set
            {
                DateTime.TryParseExact(value, "yyyyMMdd", null, System.Globalization.DateTimeStyles.RoundtripKind, out this.joinDate);
            }
        }
        public int PostCount
        {
            get
            {
                return postCount;
            }
        }
        public string Password
        {
            set 
            { 
                password = Encode(value);
            }
        }
        public int Encode(string password)
        {
            int passwordEncoded = 0;
            foreach(char carac in password)
            {
                passwordEncoded += carac;
            }
            return passwordEncoded %= 997;
        }
    }
}
