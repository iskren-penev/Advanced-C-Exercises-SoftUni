using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _12.LittleJohn
{
    public class LittleJohn
    {
        public static void Main(string[] args)
        {
            int smallArrows = 0;
            int mediumArrows = 0;
            int bigArrows = 0;
            for (int i = 0; i < 4; i++)
            {
                string inputLine = Console.ReadLine();
                Regex regex = new Regex("(>>>----->>)|(>>----->)|(>----->)");
                MatchCollection matches = regex.Matches(inputLine);
                foreach (Match match in matches)
                {
                    if (match.Groups[1].Value == ">>>----->>")
                    {
                        bigArrows++;
                    }
                    else if (match.Groups[2].Value == ">>----->")
                    {
                        mediumArrows++;
                    }
                    else if (match.Groups[3].Value == ">----->")
                    {
                        smallArrows++;
                    }
                }
            }
            string combined = string.Format("{0}{1}{2}",
                smallArrows, mediumArrows, bigArrows);
            int asDec = int.Parse(combined);
            string inBinary = Convert.ToString(asDec, 2);
            StringBuilder sb = new StringBuilder();
            sb.Append(inBinary);
            for (int i = inBinary.Length - 1; i >= 0; i--)
            {
                sb.Append(inBinary[i]);
            }
            int result = Convert.ToInt32(sb.ToString(), 2);
            Console.WriteLine(result);
        }
    }
}
