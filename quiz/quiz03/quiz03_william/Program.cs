using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace quiz03_william
{
    class Program
    {
        static void Main(string[] args)
        {
            string strInput = "";
            int recip = 0;
            int count = 0;
            do
            {
                try
                {
                    count = 0;
                    Console.Write("To calculate the reciprocal of an integer, enter a positive integer: ");
                    strInput = Console.ReadLine();


                    recip = int.Parse(strInput);
                    
                    if (recip == 0)
                    {
                        throw new IndexOutOfRangeException("Attempted to divide by zero.");
                    }
                    if (recip < 0)
                    {
                        throw new InvalidOperationException("Your number must be a positive number.");
                    }
                    Console.Write("The value is: ");
                    Console.WriteLine(1.0 / recip);
                }
                catch (FormatException fEx)
                {
                    Console.WriteLine(fEx.Message);
                    ++count;
                }
                catch (IndexOutOfRangeException iEx)
                {
                    Console.WriteLine(iEx.Message);
                    ++count;
                }
                catch (InvalidOperationException ivEx)
                {
                    Console.WriteLine(ivEx.Message);
                    ++count;
                }

            }
            while (count > 0);
        }
    }
}
