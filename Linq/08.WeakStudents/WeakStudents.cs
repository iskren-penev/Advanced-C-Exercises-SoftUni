using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.WeakStudents
{
    public class WeakStudents
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
                    grades = new List<int>
                    {
                        int.Parse(tokens[2]),
                        int.Parse(tokens[3]),
                        int.Parse(tokens[4]),
                        int.Parse(tokens[5])
                    }
                });
                inputLine = Console.ReadLine();
            }
            var weakStudents = listOfStudents
                .Where(st =>
                {
                    int count = 0;
                    foreach (var grade in st.grades)
                    {
                        if (grade < 4)
                        {
                            count++;
                        }
                    }
                    return count >= 2;
                })
                .ToList();
            foreach (var st in weakStudents)
            {
                Console.WriteLine("{0} {1}", st.firstName, st.lastName);
            }
        }
    }
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public List<int> grades { get; set; }
    }
}