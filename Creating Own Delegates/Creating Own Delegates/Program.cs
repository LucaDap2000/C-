namespace Delegates
{
    internal class Program
    {
        // Defining a delegate type called FilterDelegate that takes
        // a person object and returns a bool
        public delegate bool FilterDelegate(Person p);

        static void Main(string[] args)
        {
            // Create 4 person objects
            Person p1 = new Person() { Name = "Aiden", Age = 41 };
            Person p2 = new Person() { Name = "Sif", Age = 68 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoli", Age = 25 };

            // Add the objects to a list called people
            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            DisplayPeople("Kids", people, IsMinor);
            DisplayPeople("Adults", people, IsAdult);
            DisplayPeople("Seniors", people, IsSenior);

            // Here we create a new variable called filter of type FilterDelegate
            // then we assigned an anonymous method to it instead of an already defined method

            FilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 20 && p.Age <= 30;
            }; // Remember the ';' at the end because we are declaring a variable
               // and assigning its value at the same time just like int x = 3; for example

            DisplayPeople("Between 20 and 30", people, filter);

            DisplayPeople("All: ", people, delegate (Person p) 
            { 
                return true; 
            });

            // Statement lambda
            // A search keyword to filter the names
            string searchKeyword = "A";
            DisplayPeople("age > 20 with search keyword: " + searchKeyword, people, p =>
            {
                // Check if this person contains the search keyword and the age is > 20
                if (p.Name.Contains(searchKeyword) && p.Age > 20)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            // Expression lambda
            // Here we are using expression lambda (one line of code)
            DisplayPeople("Exactly 25: ", people, p => p.Age == 25);
        }

        // A method to display the list of people that passes the filter condition
        // (returns true)
        // This method will take a title to be displayed, the list of people
        // and a filter to delegate
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            // Print the title 
            Console.WriteLine(title);

            foreach (Person p in people)
            {
                // Check if this person passes the filter
                if (filter(p))
                {
                    // Print the persons name and age
                    Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
                }
            }
        }

        // ==========FILTERS==========
        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }
    }
}
