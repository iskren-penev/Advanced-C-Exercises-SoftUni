using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.GroupByGroup
{
    public class GroupByGroup
    {
        public static void Main(string[] args)
        {
            List<Person> listOfPeople = new List<Person>();
            string inputLine = Console.ReadLine();
            while (inputLine != "END")
            {
                string[] tokens = inputLine.Split();
                listOfPeople.Add(new Person
                {
                    name = tokens[0]+ " "+ tokens[1],
                    group = int.Parse(tokens[2])
                });
                inputLine = Console.ReadLine();
            }
            var groupedByGrops = listOfPeople
                .GroupBy(p => p.group).OrderBy(g => g.Key);
            foreach (var group   in groupedByGrops)
            {
                List<string> names = new List<string>();
                foreach (var pers in group)
                {
                    names.Add(pers.name);
                }
                Console.WriteLine("{0} - {1}",
                    group.Key, string.Join(", ", names));
            }
        }
    }
    public class Person
    {
        public string name { get; set; }
        public int group { get; set; }
    }
}
