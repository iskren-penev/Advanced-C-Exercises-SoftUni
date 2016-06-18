using System;
using System.Collections.Generic;

namespace _13.OfficeStuff
{
    public class OfficeStuff
    {
        public static void Main(string[] args)
        {
            char[] delimiters = {' ', '|', '-'};
            SortedDictionary<string, Dictionary<string, int>> officeStuff =
                new SortedDictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                string company = input[0];
                string product = input[2];
                int amount = int.Parse(input[1]);
                if (!officeStuff.ContainsKey(company))
                {
                    officeStuff.Add(company, new Dictionary<string, int>());
                }
                if (!officeStuff[company].ContainsKey(product))
                {
                    officeStuff[company].Add(product, 0);
                }
                officeStuff[company][product] += amount;
            }
            foreach (var pair in officeStuff)
            {
                List<string> products = new List<string>();
                foreach (var innerPair in pair.Value)
                {
                    products.Add(string.Format("{0}-{1}", innerPair.Key, innerPair.Value));
                }
                Console.WriteLine("{0}: {1}", pair.Key, string.Join(", ", products));
            }
        }
    }
}
