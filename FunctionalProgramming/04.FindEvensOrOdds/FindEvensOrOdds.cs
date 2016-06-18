using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FindEvensOrOdds
{
    public class FindEvensOrOdds
    {
        public static void Main(string[] args)
        {
            Predicate<long> predicate = n => n % 2 == 0; ;
            long[] range = Console.ReadLine().Split().Select(long.Parse).ToArray();
            string command = Console.ReadLine();
            if (command == "odd")
            {
                predicate = n => n % 2 != 0;
            }
            List<long> output = new List<long>();
            for (long i = range[0]; i <= range[1]; i++)
            {
                if (predicate(i))
                {
                    output.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
