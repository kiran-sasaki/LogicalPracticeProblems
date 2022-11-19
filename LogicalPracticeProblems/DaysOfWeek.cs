using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPracticeProblems
{
    public static class DaysOfWeek
    {
        public static void CalculateDays()
        {
            int y1, m1, d1,x;
            string days="days";
            Console.WriteLine("Enter The Month");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Date");
            int d =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Year");
            int y=int.Parse(Console.ReadLine());
            y1 = y - ((14 - m) / 12);
            x = y1 + ((y1 / 4 )- (y1 / 100) + (y1 / 400));
            m1 =m + ((12 * ((14 - m) / 12)) - 2);
            d1 =(d + x + ((31 * m1) / 12)) % 7;
            switch (d1)
            {
                case 0:
                    days = "sunday";
                    break;
                case 1:
                    days = "Monday";
                    break;
                case 2:
                    days = "Tuesday";
                    break;
                case 3:
                    days = "Wednesday";
                    break;
                case 4:
                    days = "Thursday";
                    break;
                case 5:
                    days = "Friday";
                    break;
                case 6:
                    days = "Saturday";
                    break;
            }
            Console.WriteLine("The Day Of The {0}/{1}/{2} is {3}", d, m, y, days);
        }
    }
}
