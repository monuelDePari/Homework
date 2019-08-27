using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace FilesByDate
{
    class Search
    {
        static void Main(string[] args)
        {
            string DateFrom, DateTo, DateNow;

            Console.Write("Write the path to the file: ");

            string Path = Console.ReadLine();

            Console.Write("Write the mask of the file: ");

            string Mask = Console.ReadLine();

            Console.WriteLine("Write the time borders of file you are searching for.");

            Console.Write("From: {0}, To: {1}", DateFrom = Console.ReadLine(), DateTo = Console.ReadLine());

            Console.WriteLine("Date now: {0}", DateNow = Convert.ToString(DateTime.Now.Date));

            if (Path[Path.Length - 1] != '\\')
                Path += '\\';

            DirectoryInfo di = new DirectoryInfo(Path);

            if (!di.Exists)
            {
                Console.WriteLine("Incorrect Path!");
                return;
            }

            Mask = Mask.Replace(".", @"\." /* (".", "\\.") */);

            Mask = Mask.Replace("?", ".");

            Mask = Mask.Replace("*", ".*");

            Mask = "^" + Mask + "$";


            DirectoryInfo[] diArray;
            try
            {
                diArray = di.GetDirectories();
            }
            catch
            {
                return;
            }
            foreach (DirectoryInfo directInfo in diArray)
            {
                if (directInfo.CreationTime.Date == DateTime.Now.Date)
                    Console.WriteLine(directInfo.Name);
            }
        }
    }
}
