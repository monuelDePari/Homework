using System;
using System.Collections.Generic;
using System.Text;

namespace SS3_2_Task
{
    class Third
    {
        public void Start()
        {
            string alltime = "4:12,2:43,3:51,4:29,3:24,3:14,4:46,3:25,4:52,3:27";
            string[] ToSeconds = alltime.Split(',');
            Console.WriteLine(alltime + "\n");
            TimeSpan total = TimeSpan.Parse($"00:{ToSeconds[0]}");
            TimeSpan prev;
            for (int i = 0; i < ToSeconds.Length; i++)
            {
                prev = (TimeSpan.Parse($"00:{ToSeconds[i]}"));
                total += prev;
                prev = total;
            }
            double x = total.TotalSeconds;
            Console.WriteLine($"Total time in format (YY:MM:DD): {total}, Format in seconds: {x} \n");
        }
        public Third()
        {
            Start();
        }
    }
}
