using System;
namespace _01.ActionPrint
{
    public class ActionPrint
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Action<string> act = n => Console.WriteLine(n);
            foreach (var s in input)
            {
                act(s);
            }
        }
    }
}
