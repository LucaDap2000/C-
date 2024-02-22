namespace Inheritance_Challenge_2___Employees__Bosses_and_Trainees
{
    internal class Program
    {
        /* Create a main class with the Main method, then a base class employee with the properties Name,
         * FirstName, Salary and the methods Work() and Pause()
         * Create a deriving class boss with the property CompanyCar and the method Lead()
         * Create another deriving class of employees - trainees with the properties WorkingHours and SchoolHours
         * and a method Learn()
         * Overried the methods Work() of the trainee class so that it indicates
         * the working hours of the trainee
         * Don't forget to create the constructors
         * Create an object of each of the three classes (with arbitrary values)
         * and call the methods, Lead() of Boss and Work() of Trainee
         * Print out the respective text of what the respective employees do
        */

        static void Main(string[] args)
        {
            // Create an employee and make them work and pause
            Employee Luca = new Employee("Luca", "D'Aprano", 50000);
            Luca.Work();
            Luca.Pause();

            // Create a boss and make them lead
            Boss chuckNorris = new Boss("Ferrari", "Norris", "Chuck", 999999);
            chuckNorris.Lead();

            // Create a trainee and ask them how long they've studied for
            // and how long they've worked for
            Trainee michelle = new Trainee(32, 8, "Gartner", "Michelle", 20000);
            michelle.Learn();
            michelle.Work();

            Console.ReadKey();
        }
    }
}
