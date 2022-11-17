using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPracticeProblems
{
    public static class VendingMachine
    {
        public static void countCurrency()
        {
            Console.WriteLine("Enter The Amount :");
            int amount=int.Parse(Console.ReadLine());
            int[] notes = new int[] { 1000, 500, 200, 100, 50, 20, 10, 5, 1 };
            int[] noteCounter = new int[9];
            // count notes
            for (int i = 0; i < 9; i++)
            {
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];
                    amount = amount % notes[i];
                }
            }
            // Print notes
            Console.WriteLine("Currency Count :");
            for (int i = 0; i < 9; i++)
            {
                if (noteCounter[i] != 0)
                {
                    Console.WriteLine(notes[i] + " : " + noteCounter[i]);
                }
            }
        }
    }
}
