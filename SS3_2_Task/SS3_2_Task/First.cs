using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SS3_2_Task
{
    class First
    {
        public void Start()
        {
            string s = "Davis, Clyne, Fonte, Hooived, Shaw, Davis, Scheiderlin, Cork, Lallana, Rodriguez, Lambert";
            string[] splited = s.Split(',');
            Console.WriteLine(s + "\n");
            IEnumerable<int> iterator = Enumerable.Range(1, splited.Length);
            foreach(int x in iterator)
            {
                splited[x - 1] = $"{x - 1}. {splited[x - 1]}";
            }
            s = splited.Aggregate((cur, next) => cur + ", " + next);
            Console.WriteLine($"New line is: {s} \n");
        }
        public First()
        {
            Start();
        }
    }
}
