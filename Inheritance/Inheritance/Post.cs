using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Post
    {
        private static int currentPostId;

        // Properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUserName { get; set; }
        public bool IsPublic { get; set; }

        /* Default constructor. If a derived class does not invoke a base
         * class constructor explicitly, the default constructor is called implicitly
        */

        public Post()
        {
            ID = GetNextID();
            Title = "My First Post";
            IsPublic = true;
            SendByUserName = "Luca D'Aprano";
        }

        // Instance constructor that has three parameters
        public Post(string title, bool isPublic, string sendByUserName)
        {
            this.ID = 0;
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        // Virtual method override of the ToString method that is inherited
        // from System.Object
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUserName);
        }
    }
}
