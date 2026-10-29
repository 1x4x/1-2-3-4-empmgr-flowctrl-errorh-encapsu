using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walter_practises.kattis.k1002
{
    internal class SortTwoNumbersManager : walter_practises.Interface.IManager
    {
        public void Heading()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("https://open.kattis.com/problems/sorttwonumbers");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("=== Sort two numbers ===");
            Console.WriteLine("Input two numbers and the program will write the lowest first and then the highest.");
            Console.WriteLine("If 2 numbers are not given we will use 777 and 333.");
            Console.ResetColor();
        }

        public void Start()
        {
            Heading();

            string[] input = Console.ReadLine().Split();

            int i1 = 0;
            int i2 = 0;

            // If the user does not provide input, use default values
            // also prevents error if we dont have all 3 numbers
            if (string.IsNullOrEmpty(input[0]) ||
                string.IsNullOrEmpty(input[1]))
            {
                i1 = 777;
                i2 = 333;
                
                if (i1 < i2)
                {
                    Console.WriteLine(i1);
                    Console.WriteLine(i2);
                }
                else
                {
                    Console.WriteLine(i2);
                    Console.WriteLine(i1);
                }
            }
            else
            {
                i1 = int.Parse(input[0]);
                i2 = int.Parse(input[1]);
                if (i1 < i2)
                {
                    Console.WriteLine(i1);
                    Console.WriteLine(i2);
                }
                else
                {
                    Console.WriteLine(i2);
                    Console.WriteLine(i1);
                }
            }

            
            
        }
    }
}
