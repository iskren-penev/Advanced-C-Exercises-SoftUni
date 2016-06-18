using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    public class ListOfPredicates
    {
        public static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> output = new List<int>();
            Func<int[], int, bool> chekcer = Predicates;
            for (int i = 1; i <= range; i++)
            {
                if (chekcer(numbers, i))
                {
                    output.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", output));
        }

        public static bool Predicates(int[] nums, int n)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (n % nums[i] == 0)
                {
                    counter++;
                }
            }
            if (counter == nums.Length)
            {
                return true;
            }
            return false;
        }
    }
}
