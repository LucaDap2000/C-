using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members___Finalisers_Destructors
{
    internal class Members
    {
        // Member private field(s)

        private string _memberName;
        private string _jobTitle;
        private int _salary;

        // Member public field(s)

        public int _age;

        // Member property - exposes field safely - properties start with a capital letter

        public string JobTitle
        {
            get
            {
                return JobTitle;
            }
            set
            {
                JobTitle = value;
            }
        }

        // Public member method - can be called from other classes

        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}. I'm {2} years old.", _memberName, _jobTitle, _age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", _salary);
        }

        // Member constructor

        public Members()
        {
            _age = 30;
            _memberName = "Lucy";
            _jobTitle = "Developer";
            _salary = 60000;
            Console.WriteLine("Object created");
        }

        // Member - finaliser/destrcutor

        ~Members()
        {
            // Clean up statements
            Console.WriteLine("Deconstruction of members object");
            Debug.Write("Deconstruction of members object");
        }
    }
}
