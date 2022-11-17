using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPracticeProblems
{
    public static class CouponNumber
    {
        public static void GenerateCouponNumber()
        {
            Console.Write("Enter the end of coupon no: ");
            int number = int.Parse(Console.ReadLine());
            //Variable
            int n = 0;
            int[] coupons = new int[number];
            //Random Class
            Random r = new Random();
            int num_count = 0;
            while (n < number)
            {
                //Random Number Generation
                int randomnumber = r.Next(number + 1);
                num_count++;
                if (coupons.Contains(randomnumber))
                {
                    //If the Number exist in array continue the for loop
                    continue;
                }
                else
                {
                    //If the Number does exist in array storing number in array
                    coupons[n] = randomnumber;

                }
                n++;
            }
            foreach (int coupon in coupons)
            {
                Console.WriteLine(coupon + " ");
            }
            Console.WriteLine("the count needed to generate is: " + num_count);
        }
    }
}
