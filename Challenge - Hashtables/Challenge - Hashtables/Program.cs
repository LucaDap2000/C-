using System;
using System.Collections;

namespace Challenge___Hashtables
{
    // CHALLENGE:
    /* 
    Write a program that will iterate through each element of the students array and insert them into a hashtable.
    If a student with the same ID already exists in the hashtable skip it and display the following error:
    "Sorry, a student with the same ID already exists."
    Use the method ContainsKey() to check whether a student with the same ID already exists
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student(1, "Luca", 88);
            students[1] = new Student(2, "Mary-Kate", 97);
            students[2] = new Student(6, "Steve", 65);
            students[3] = new Student(1, "Louise", 73);
            students[4] = new Student(4, "Pete", 58);

            #region My solution

            Hashtable studentsTable = new Hashtable();

            for (int i = 0; i < students.Length; i++)
            {
                try
                {
                    studentsTable.Add(students[i].Id, students[i]);
                    Console.WriteLine("Student with ID: {0} was added!", students[i].Id);

                }
                catch(Exception)
                {
                    Console.WriteLine("Sorry, a student with the same ID already exists ID: {0}", students[i].Id);
                }
            }

            #endregion End of my solution

            #region Teacher solution

            foreach (Student s in students)
            {
                if (!studentsTable.ContainsKey(s.Id))
                {
                    studentsTable.Add(s.Id, s);
                    Console.WriteLine("Student with ID: {0} was added!", s.Id);
                }
                else
                {
                    Console.WriteLine("Sorry, a student with the same ID already exists ID: {0}", s.Id);
                }
            }

            #endregion End of teacher solution

        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student (int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
