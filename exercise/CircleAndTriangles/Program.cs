using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ex01_william
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            //Part 1
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            // Implementation for area here
            do
            {
                try
                {
                    count = 0;
                    Console.Write("Enter an integer for the radius: ");
                    string strradius = Console.ReadLine();
                    int intradius = int.Parse(strradius);
                    if (intradius <= 0)
                    {
                        throw new OperationCanceledException("Your nubmer is out of range");
                    }
                    double circumference = 2 * Math.PI * intradius;
                    Console.WriteLine($"The circumference is {circumference}");
                    double area = Math.PI * (intradius * intradius);
                    Console.WriteLine($"The area is {area}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must enter a valid number");
                    count++;
                }
                catch (OperationCanceledException oEx)
                {
                    Console.WriteLine(oEx.Message);
                    count++;
                }
                finally
                {
                    Console.WriteLine("Okay");
                }
            }
            while (count > 0);

            // Part 2
            Console.WriteLine("\nPart 2, volume of a hemisphere.");
            // Implementation here
            do
            {
                try
                {
                    count = 0;
                    Console.Write("Enter an integer for the raius: ");
                    String strradius2 = Console.ReadLine();
                    int intradius2 = int.Parse(strradius2);

                    if(intradius2 <= 0)
                    {
                        throw new OperationCanceledException("Your nubmer is out of range");
                    }
                    double volume = ((4 * (Math.PI * (intradius2 * intradius2 * intradius2))) / 3) / 2;
                    Console.WriteLine($"The volume is {volume}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must enter a valid number");
                    count++;
                }
                catch (OperationCanceledException oEx)
                {
                    Console.WriteLine(oEx.Message);
                    count++;
                }
                finally
                {
                    Console.WriteLine("Okay");
                }
            }
            while (count > 0);

            // Part 3
            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
            // Implementation here
            do
            {
                try
                {
                    count = 0;
                    double Area = 0;
                    Console.Write("please enter an integer for side a: ");
                    string sidea = Console.ReadLine();
                    int a = int.Parse(sidea);

                    if(a <= 0)
                    {
                        throw new OperationCanceledException("Your nubmer is out of range");
                    }

                    Console.Write("please enter an integer for side b: ");
                    string sideb = Console.ReadLine();
                    int b = int.Parse(sideb);

                    if (b <= 0)
                    {
                        throw new OperationCanceledException("Your nubmer is out of range");
                    }

                    Console.Write("please enter an integer for side c: ");
                    string sidec = Console.ReadLine();
                    int c = int.Parse(sidec);

                    if (c <= 0)
                    {
                        throw new OperationCanceledException("Your nubmer is out of range");
                    }

                    double p = (a + b + c) / 2;
                    Area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    Console.WriteLine($"The area is {Area}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must enter a valid number");
                    count++;
                }
                catch (OperationCanceledException oEx)
                {
                    Console.WriteLine(oEx.Message);
                    count++;
                }
                finally
                {
                    Console.WriteLine("Okay");
                }
            }
            while (count > 0);

            // Part 4
            Console.WriteLine("\nPart 4, solving a quadratic equation.");
            // Implementation here
            do
            {
                try
                {
                    count = 0;
                    Console.Write("enter an interger for coefficient a: ");
                    string coefa = Console.ReadLine();
                    int a1 = int.Parse(coefa);

                    if (a1 <= 0)
                    {
                        throw new OperationCanceledException("Your nubmer is out of range");
                    }

                    Console.Write("enter an interger for coefficient b: ");
                    string coefb = Console.ReadLine();
                    int b1 = int.Parse(coefb);

                    if (b1 <= 0)
                    {
                        throw new OperationCanceledException("Your nubmer is out of range");
                    }

                    Console.Write("enter an interger for coefficient c: ");
                    string coefc = Console.ReadLine();
                    int c1 = int.Parse(coefc);

                    if (c1 <= 0)
                    {
                        throw new OperationCanceledException("Your nubmer is out of range");
                    }

                    double denominator = 2 * a1;
                    double positive_num = -b1 + Math.Sqrt(b1 * b1 - (4 * a1 * c1));
                    double negative_num = -b1 - Math.Sqrt(b1 * b1 - (4 * a1 * c1));
                    Console.WriteLine($"The positive solution is {positive_num / denominator}");
                    Console.WriteLine($"The negative solution is {negative_num / denominator}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must enter a valid number");
                    count++;
                }
                catch (OperationCanceledException oEx)
                {
                    Console.WriteLine(oEx.Message);
                    count++;
                }
                finally
                {
                    Console.WriteLine("Okay");
                }
            }
            while (count > 0);
        }
    }
}
