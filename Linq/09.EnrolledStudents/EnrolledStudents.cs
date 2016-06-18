using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.EnrolledStudents
{
    public class EnrolledStudents
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
                    enrollNumber = tokens[0],
                    grades = new int[]
                    {
                        int.Parse(tokens[1]),
                        int.Parse(tokens[2]),
                        int.Parse(tokens[3]),
                        int.Parse(tokens[4])
                    }
                });
                inputLine = Console.ReadLine();
            }
            var sortedStudents = listOfStudents
                .Where(st => st.enrollNumber.EndsWith("15") || st.enrollNumber.EndsWith("14"))
                .ToList();
            foreach (var st in sortedStudents)
            {
                Console.WriteLine(string.Join(" ", st.grades));
            }
        }
    }

    public class Student
    {
        public string enrollNumber { get; set; }
        public int[] grades { get; set; }
    }
}
