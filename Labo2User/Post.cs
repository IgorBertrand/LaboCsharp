using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2User
{
    internal class Post
    {
        private User author;
        private string contents;
        private DateTime date;
        public User[] likedBy = new User[INC_LIKEDBY_SIZE];
        public  const int INC_LIKEDBY_SIZE = 3;
        public Post(User author, string contents, DateTime date)
        {
            this.author = author;
            this.contents = contents;
            this.date = date;
            this.author.AddPost(contents);
        }
        public Post(User author, string contents) : this(author, contents, DateTime.Now) 
        { 
        }
        public override string ToString()
        {
            string message = "";
            message += author.ToString() + "\n" + contents + "\t" + date + "\n";
            foreach(var item in likedBy)
            {
                if(item != null)
                {
                    message += item.Login + "\n";
                }
            }
            return message;
        }
        public void AddLike(User user)
        {
            bool isLike = false;
            for(int iUser = 0; iUser < this.likedBy.Length; iUser++)
            {
                if (this.likedBy[iUser] == null) 
                {
                    this.likedBy[iUser] = user;
                    iUser += this.likedBy.Length;
                    isLike = true;
                }
            }
            if (!isLike)
            {
                Console.WriteLine("Array full");
                User[] newLikedBy = new User[this.likedBy.Length + INC_LIKEDBY_SIZE];
                int iNewLikedBy = 0;
                foreach(User like in this.likedBy)
                {
                    newLikedBy[iNewLikedBy++] = like;
                }
                this.likedBy = newLikedBy;
                AddLike(user);
            }
        }
        public void AddLike(params User[] users)
        {
            foreach(User user in users)
            {
                AddLike(user);
            }
        }
        public void RemoveLike(User user)
        {
            for(int iUser = 0; iUser < this.likedBy.Length; iUser++)
            {
                if (this.likedBy[iUser] == user) 
                {
                    this.likedBy[iUser] = null;
                    iUser += this.likedBy.Length;
                }
            }
        }
    }
}
