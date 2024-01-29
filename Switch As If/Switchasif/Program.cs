namespace Switchasif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string age;
            Console.WriteLine("Please input your age here: ");
            age = Console.ReadLine();
            int ageAsInt = Convert.ToInt32(age);
            if(ageAsInt == 15)
            {
                Console.WriteLine("Too young to party in the club!");
            }
            else if(ageAsInt == 25)
            {
                Console.WriteLine("Good to go!");
            }
            else
            {
                Console.WriteLine("How old are you then?");
            }

            Console.Read();

        }
    }
}