using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.StudentsByGroup
{
    public class StudentsByGroup
    {
        public static void Main(string[] args)
        {
            List<Student> listOfStudents = new List<Student>();
            string inputLine = Console.ReadLine();
            while (inputLine!= "END")
            {
                string[] tokens = inputLine.Split();
                listOfStudents.Add(new Student
                {
                    firstName = tokens[0],
                    lastName = tokens[1],
                    group = int.Parse(tokens[2])
                });
                inputLine = Console.ReadLine();
            }
            var sortedByGroup = listOfStudents
                .Where(st => st.group == 2)
                .OrderBy(st => st.firstName)
                .ToList();
            foreach (var student in sortedByGroup)
            {
                Console.WriteLine("{0} {1}", student.firstName, student.lastName);
            }
        }
    }
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int group { get; set; }
    }
}
