using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    public class ReverseAndExclude
    {
        public static void Main(string[] args)
        {
            Func<int[],int, int[]> reverseExcludeFunc = ReverseList ;
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] output =reverseExcludeFunc(input, n);
            Console.WriteLine(string.Join(" ", output));
        }

        public static int[] ReverseList(int[] input, int n)
        {
            List<int> result = new List<int>();
            Predicate<int> isNotDivisable = x => x%n != 0;
            for (int i = input.Length-1; i >= 0; i--)
            {
                if (isNotDivisable(input[i]))
                {
                    result.Add(input[i]);
                }
            }
            return result.ToArray();
        }
    }
}
