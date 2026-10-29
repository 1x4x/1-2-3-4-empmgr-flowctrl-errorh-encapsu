using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walter_practises.kattis.k1001
{
    internal class MaximumNumberManager : walter_practises.Interface.IManager
    {
        public void Heading()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("https://open.kattis.com/problems/maximumnumber");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            Console.WriteLine("=== Maximum Number ===");
            Console.WriteLine("Input a number at a time and the program will find the maximum number.");
            Console.ResetColor();
        }

        public void Start()
        {
            Heading();

            int max = 0;
            while (true)
            {
                string input = Console.ReadLine();

                int n;
                bool isNumeric = int.TryParse(input, out n);
                if (isNumeric == false) { break; }
                if (Convert.ToInt32(input) < 0) { break; }
                if (Convert.ToInt32(input) > max)
                {
                    max = Convert.ToInt32(input);
                }
            }

            Console.WriteLine(max);
        }
    }
}
