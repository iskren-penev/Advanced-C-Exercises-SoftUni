using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.StudentSpecialties
{
    public class StudentSpecialties
    {
        public static void Main(string[] args)
        {
            List<Specialty> specialties = new List<Specialty>();
            List<Student> students = new List<Student>();
            string inputLine = Console.ReadLine();
            while (inputLine != "Students:")
            {
                string[] tokens = inputLine.Split();
                specialties.Add(new Specialty
                {
                    specialtyName = tokens[0] + " " + tokens[1],
                    facultyNumber = int.Parse(tokens[2])
                });
                inputLine = Console.ReadLine();
            }
            inputLine = Console.ReadLine();
            while (inputLine != "END")
            {
                string[] tokens = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                students.Add(new Student
                {
                    studentName = tokens[1] + " " + tokens[2],
                    facultyNumber = int.Parse(tokens[0])
                });
                inputLine = Console.ReadLine();
            }
            var studentSpecialties = specialties.
                Join(students,
                    st => st.facultyNumber,
                    sp => sp.facultyNumber,
                    (sp, st) => new { st.studentName, sp.facultyNumber, sp.specialtyName })
                    .OrderBy(stSp => stSp.studentName);
            foreach (var student in studentSpecialties)
            {
                Console.WriteLine("{0} {1} {2}",
                    student.studentName, student.facultyNumber, student.specialtyName);
            }
        }
    }

    public class Student
    {
        public string studentName { get; set; }
        public int facultyNumber { get; set; }
    }

    public class Specialty
    {
        public string specialtyName { get; set; }
        public int facultyNumber { get; set; }
    }
}
