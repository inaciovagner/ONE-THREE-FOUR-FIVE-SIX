using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_one_three
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] words = new string[,] {
               { "ONE", "TWO" },
               { "THREE", "FOUR" },
               { "FIVE", "SIX" }
            };
            for (int i = 0; i < words.Length / 2; i++)
            {
                string s1 = words[i, 0];
                string s2 = words[i, 1];
                Console.WriteLine("{0}, {1}", s1, s2);
            }
        }
    }
}