using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Kata7_2
{
    class Program
    {
        public static string HighAndLow(string numbers)
        {
            int[] n;
            int i = 0;
            string[] n2 = numbers.Split(" ");
            n = new int[n2.Length];
            foreach (var item in n2)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    n[i] = int.Parse(item);
                    ++i;
                }
            }
            Array.Sort(n);
            string result = Convert.ToString(n[n.Length - 1]) + " " + Convert.ToString(n[0]);
            return result;
        }
        static void Main(string[] args)
        {
            string n = HighAndLow("-1 -1 -1");
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
