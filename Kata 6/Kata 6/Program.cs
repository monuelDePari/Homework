using System;
using System.Text.RegularExpressions;
namespace Kata_6
{
    class Program
    {
        public static int Test(string numbers)
        {
            int position = 0, i = 0;
            char even = ' ', odd = ' ';
            int[] arr;
            if (numbers.Length % 2 == 0)
            {
                arr = new int[numbers.Length / 2];
            }
            else
            {
                arr = new int[numbers.Length / 2 + 1];
            }
            string[] numbers1 = Regex.Split(numbers, @"\D+");
            foreach (var item in numbers1)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    arr[i] = int.Parse(item);
                    ++i;
                }
            }

            if (arr[0] % 2 == 0)
            {
                even = 'y';
            }
            else if (arr[0] % 2 == 1)
            {
                even = 'n';
            }

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] % 2 == 0)
                {
                    odd = 'y';
                }
                else if (arr[j] % 2 == 1)
                {
                    odd = 'n';
                }
                if(odd != even)
                {
                    if (arr[0] % 2 != arr[1] % 2 && arr[1] % 2 == arr[2] % 2)
                    {
                        position = 0;
                        break;
                    }
                    else
                    {
                        position = j;
                        break;
                    }
                }
            }
            ++position;
            return position;
        }
        static void Main(string[] args)
        {
            int n = Test("223 222 2 6 8 4 4422");
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
