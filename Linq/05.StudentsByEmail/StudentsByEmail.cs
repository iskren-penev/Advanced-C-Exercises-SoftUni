using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.StudentsByEmail
{
    public class StudentsByEmail
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
                    email = tokens[2]
                });
                inputLine = Console.ReadLine();
            }
            var sortedStudents = listOfStudents
                .Where(st => st.email.EndsWith("@gmail.com"))
                .ToList();
            foreach (var st in sortedStudents)
            {
                Console.WriteLine("{0} {1}", st.firstName, st.lastName);
            }
        }
    }
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
    }
}

