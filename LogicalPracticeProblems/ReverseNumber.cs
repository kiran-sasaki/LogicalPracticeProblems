using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPracticeProblems
{
    public static class ReverseNumber
    {
        public static void ReversedNumber()
        {
            Console.WriteLine("enter a Number");
            //Variables
            int num = int.Parse(Console.ReadLine());
            int rev = 0;
            //WhileLoop For Iteration
            while (num > 0)
            {
                //Condition for Reversing Number
                int rem = num % 10;
                rev = (rev * 10) + rem;
                num = num / 10;
            }
            Console.WriteLine("{0} is the Reversed Number",rev);
        }
    }
}
