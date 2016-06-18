using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.CustomMinFunction
{
    public class CustomMinFunction
    {
        public static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Func<List<int>, int> func = MinElement;
            Console.WriteLine(func(input));
        }

        public static int MinElement(List<int> input)
        {
            return input.Min();
        }
    }
}
