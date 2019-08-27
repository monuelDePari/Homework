using System;
using System.Collections.Generic;
using System.Linq;

namespace SS3_2_Task
{
    class DateSort
    {
        public void SortByDate()
        {
            DateTime cur = DateTime.Now;
            string thread = "Jason Puncheon, 26/06/1986; Jos Hooiveld, 22/04/1983; Kelvin Davis, 29/09/1976; Luke Shaw, 12/07/1995; Gaston Ramirez, 02/12/1990; Adam Lallana, 10/05/1988";
            Console.WriteLine(thread + "\n");
            string[] splitedThread = thread.Split("; ");
            var player = splitedThread.Select(player_with_year =>
            {
                string[] info = player_with_year.Split(", ");
                string name = info[0];
                string[] Date = info[1].Split("/");
                DateTime date = new DateTime(Convert.ToInt32(Date[2]), Convert.ToInt32(Date[1]), Convert.ToInt32(Date[0]));
                return new { name, date };
            })
            .OrderByDescending(player_with_year => player_with_year.date.Year);
            foreach(var play in player)
            {
                int timeSpan = cur.Year - play.date.Year;
                Console.WriteLine($"{play.name} \t {timeSpan}");
            }
            Console.WriteLine();
        }
        public DateSort()
        {
            SortByDate();
        }
    }
}
