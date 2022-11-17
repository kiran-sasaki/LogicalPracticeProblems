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
            //Object of Stopwatch class
            Stopwatch stopwatch = new Stopwatch();
            //Starting StopWatch
            stopwatch.Start();
            for (int i = 0; i < time; i++)
            {
                System.Threading.Thread.Sleep(10);
            }
            //Stopping StopWatch
            stopwatch.Stop();

            Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }
    }
}
