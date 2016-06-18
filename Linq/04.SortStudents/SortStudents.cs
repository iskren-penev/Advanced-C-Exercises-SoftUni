using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SortStudents
{
    public class SortStudents
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
                    lastName = tokens[1]
                });
                inputLine = Console.ReadLine();
            }
            var sortedStudents = listOfStudents
                .OrderBy(st => st.lastName)
                .ThenByDescending(st => st.firstName)
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
    }
}




