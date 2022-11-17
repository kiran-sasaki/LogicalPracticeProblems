using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPracticeProblems
{
    public static class TemperatureConversion
    {
        public static void Tempreature()
        {
            Console.WriteLine("Press: 1. To Convert Into Farenheit 2.To Convert Into Celsius");
            int input =int.Parse(Console.ReadLine());
            switch(input)
            {
                case 1:
                    //Converting Into Fahernheit
                    Console.WriteLine("Enter The Temperature To Convert into Fahernheit");
                    double celsius=double.Parse(Console.ReadLine());
                    //Formula for Converting Into Fahernheit
                    double fr = (celsius * 9) / 5 + 32;
                    Console.WriteLine("{0} is in fahereheit",fr);
                    break;
                case 2:
                    //Converting Into Celsius
                    Console.WriteLine("Enter The Temperature To Convert into Celsius");
                    double faherenheit = double.Parse(Console.ReadLine());
                    //Formula for Converting Into celsius
                    double cl = (faherenheit - 32) * 5 / 9;
                    Console.WriteLine("{0} is in celsius",cl);
                    break;
            }
        }
    }
}
