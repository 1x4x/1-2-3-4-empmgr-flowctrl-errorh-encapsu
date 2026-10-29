using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walter_practises.kattis.k1000
{
    internal class FizzBuzzManager : walter_practises.Interface.IManager
    {
        public void Start()
        {
            Heading();
            string[] input = Console.ReadLine().Split();
            int x, y, n;

            // If the user does not provide input, use default values
            // also prevents error if we dont have all 3 numbers
            if (string.IsNullOrEmpty(input[0]) || 
                string.IsNullOrEmpty(input[1]) || 
                string.IsNullOrEmpty(input[2]))
            {
                x = 3; y = 5; n = 100;
            }
            else
            {
                x = int.Parse(input[0]);
                y = int.Parse(input[1]);
                n = int.Parse(input[2]);
            }
            FizzBuzz(x, y, n);
        }

        public void Heading()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("https://open.kattis.com/problems/fizzbuzz");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("=== FizzBuzz ===");
            Console.WriteLine("input 3 numbers (x,y,n) separated by space for example: 3 5 100");
            Console.WriteLine("if you write nothing i will use: 3 5 100");
            Console.ResetColor();
        }

        public static void FizzBuzz(int x, int y, int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % x == 0 && i % y == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % x == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % y == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
