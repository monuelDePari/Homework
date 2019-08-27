using System;

namespace Kata7
{
    class Program
    {
        public static string AddBinary(int a, int b)
        {
            string binary = "";
            int temp = 0;
            a += b;
            while(a > 0)
            {
                temp = a % 2;
                binary = binary + Convert.ToString(temp);
                a /= 2;
            }
            char[] arr = binary.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        static void Main(string[] args)
        {
            string n = AddBinary(31, 21);
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
