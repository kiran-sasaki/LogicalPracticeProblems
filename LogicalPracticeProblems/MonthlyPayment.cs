using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPracticeProblems
{
    public static class MonthlyPayment
    {
        public static void CalculatePayment()
        {
            //Variables
            double n, r,payment;
            Console.WriteLine("Enter The Princpal Loan Amount");
            double P=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter No of Years");
            double Y =double.Parse(Console.ReadLine());
            Console.WriteLine("Enter The percent interest compounded monthly.");
            double R =double.Parse(Console.ReadLine());
            //calculating No of Terms
            n = 12 * Y;
            //calculating Intrest
            r = R / (12 * 100);
            //Calculating Monthly Payment
            payment = (P * r) / (1 - (Math.Pow(1+r,-n)));
            Console.WriteLine("The Monthly Payment is Rs{0}",payment);
        }
    }
}
