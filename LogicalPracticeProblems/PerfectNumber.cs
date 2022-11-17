using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPracticeProblems
{
    public static class PerfectNumber
    {
        public static void PerfectNumberCheck()
        {
            Console.WriteLine("Enter The Number");
            int num = int.Parse(Console.ReadLine());
            //Variables
            int i = 1;
            int total = 0;
            //CheckingPerfectNumber
            for (i = 1; i < num; i++)
            {
                if (num % i == 0)
                    total += i;
            }
            if (total == num)
                Console.Write("{0} is a perfect number", num);
            else
                Console.Write("{0} is not a perfect number", num);
        }
    }
}
