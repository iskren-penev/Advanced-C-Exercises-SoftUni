using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.StudentsByAge
{
    public class StudentsByAge
    {
        public static void Main(string[] args)
        {
            List<Student> listOfStudents = new List<Student>();
            string inputLine = Console.ReadLine();
            while (inputLine != "END")
            {
                string[] tokens = inputLine.Split();
                listOfStudents.Add(new Student
                {
                    firstName = tokens[0],
                    lastName = tokens[1],
                    age = int.Parse(tokens[2])
                });
                inputLine = Console.ReadLine();
            }
            var sortedStudents = listOfStudents
                .Where(st => st.age > 17 && st.age < 25)
                .ToList();
            foreach (var st in sortedStudents)
            {
                Console.WriteLine("{0} {1} {2}", st.firstName, st.lastName, st.age);
            }
        }
    }
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
    }
}
