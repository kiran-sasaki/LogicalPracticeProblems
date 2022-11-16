using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPracticeProblems
{
    public static class StopWatch
    {
        public static void Timer()
        {
            Console.WriteLine("enter the time to stop");
            int time = int.Parse(Console.ReadLine());
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < time; i++)
            {
                System.Threading.Thread.Sleep(10);
            }
            stopwatch.Stop();

            Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }
    }
}
