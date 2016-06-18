using System;
using System.Linq;

namespace _08.CustomComparer
{
    public class CustomComparer
    {
        public static Predicate<int> predicate = n => n % 2 == 0;
        public static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(input, (x1, x2) =>
              {
                  if (!predicate(x1) && predicate(x2))
                  {
                      return 1;
                  }
                  if (predicate(x1) && !predicate(x2))
                  {
                      return -1;
                  }
                  return x1.CompareTo(x2);
              });
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
