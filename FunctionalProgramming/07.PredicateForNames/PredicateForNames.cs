using System;

namespace _07.PredicateForNames
{
    public class PredicateForNames
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            Predicate<string> filter = x => x.Length <= n;
            foreach (var name in names)
            {
                if (filter(name))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
