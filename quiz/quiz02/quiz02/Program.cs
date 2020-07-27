using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace quiz02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is C Sharp quiz 2.");
            Console.Write("Please enter the number of integers to add: ");
            string strNumber = Console.ReadLine();
            int end = Int32.Parse(strNumber);
            int start = 0;
            int sum = 0;
            sum = GetSums(start, end, sum);
            Console.WriteLine($"the sum is { sum}");
        }

        private static int GetSums(int start, int end, int sum)
        {

            if (end != 0)
            {
                sum = end + GetSums(start, end - 1 , sum);
                Console.WriteLine($"The sum of {end} and {sum - end} is {sum}");
                return sum;
            }
            else
                Console.WriteLine($"The sum of {end} and {sum - end} is {sum}");
            return sum;
        }
    }
}
