using System;
using System.Collections;

namespace Hashtables
{
    internal class Program
    {
        // Key - Value
        // Macchina - Car

        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student pupil1 = new Student(1, "Maria", 98);
            Student pupil2 = new Student(2, "Jason", 76);
            Student pupil3 = new Student(3, "Clara", 43);
            Student pupil4 = new Student(4, "Steve", 55);

            studentsTable.Add(pupil1.Id, pupil1);
            studentsTable.Add(pupil2.Id, pupil2);
            studentsTable.Add(pupil3.Id, pupil3);
            studentsTable.Add(pupil4.Id, pupil4);

            // Retrieve individual item with known ID

            Student storedStudent1 = (Student)studentsTable[pupil1.Id];

            // Retrieve all values from a Hashtable

            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student ID:{0}", temp.Id);
                Console.WriteLine("Student Name:{0}", temp.Name);
                Console.WriteLine("Student GPA:{0}", temp.GPA);
            }

            // More elegant way of accessing studentsTable entries

            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine("Student ID:{0}", value.Id);
                Console.WriteLine("Student Name:{0}", value.Name);
                Console.WriteLine("Student GPA:{0}", value.GPA);
            }

            Console.WriteLine("Student ID:{0}, Name:{1}, GPA:{2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);

        }
    }

    class Student
    {
        // Property called Id
        public int Id { get; set; }

        // Property called Name
        public string Name { get; set; }

        // Property called GPA
        public float GPA { get; set; }

        // Simple constructor
        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
