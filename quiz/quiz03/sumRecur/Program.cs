using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace sumRecur
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = getSum(0, 0);
            Console.WriteLine($"sum is {sum}");

            Console.WriteLine("enter a integer: ");
            string strNum = Console.ReadLine();
            int num = int.Parse(strNum);
            int fac = factorial(num);
            Console.WriteLine($"the factorial of {num} is {fac}");
        }

        private static int factorial(int num)
        {
            if (num == 0)
                return 1;
            else
                return num * factorial(num - 1);
        }

        private static int getSum(int sum, int count)
        {
            Console.WriteLine("enter an integer: ");
            string strInput = Console.ReadLine();
            sum += int.Parse(strInput);
            ++count;
            if (count < 3)
                return getSum(sum, count);
            else
                return sum;
        }
    }
}
