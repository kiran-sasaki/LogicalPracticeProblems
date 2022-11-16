using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPracticeProblems
{
    public static class PrimeNumber
    {
        public static void NumberCheck()
        {
            Console.Write("Enter a Number : ");
            //Variable
            int number = int.Parse(Console.ReadLine());
            int IsPrime = 0;
            //Itreating Using For Loop
            for (int i = 2; i < number; i++)
            {
                //Condition For Checking Number Is prime or Not Prime
                if (number % i == 0)
                {
                    Console.Write("{0} is not a Prime Number.",number);
                    IsPrime = 1;
                    break;
                }
            }
            if (IsPrime == 0)
            {
                Console.Write("{0} is a Prime Number.",number);
            }
        }
    }
}
