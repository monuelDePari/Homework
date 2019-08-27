using System;

namespace Kata7_1
{
    class Program
    {
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int count = 0;
            percent /= 100;
            
            while (p0 < p)
            {
                count++;
                p0 = (int)(p0 + (int)(p0 * percent) + aug);
            }
            return count;
        }
        static void Main(string[] args)
        {
            //nb_year()-> 15
            //int n = NbYear(1000, 2, 50, 1200);
            //Console.WriteLine(n);
            //Console.ReadKey();
        }
    }
}
