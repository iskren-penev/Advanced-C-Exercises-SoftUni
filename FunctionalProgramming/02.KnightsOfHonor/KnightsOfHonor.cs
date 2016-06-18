using System;

namespace _02.KnightsOfHonor
{
    public class KnightsOfHonor
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Action<string> act = n => Console.WriteLine(n);
            foreach (var s in input)
            {
                act("Sir " + s);
            }
        }
    }
}
