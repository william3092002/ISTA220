using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ex02_william
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPart 1, sum 10 numbers.");
            int sum = sumTenInts(0, 0);
            Console.WriteLine($"The sum of ten integers is {sum}");

            Console.WriteLine("\nPart 2, average 10 numbers");
            char letterGrade = 'X';
            double avg = AvgTenInts(0, 0);
            letterGrade = convertNumericToLetterGrade(avg);
            Console.WriteLine($"The average of ten integers is {avg}");
            Console.WriteLine($"The letter grade is {letterGrade}");

            Console.WriteLine("\nPart 3, average user prdetermined number of scores.");
            Console.Write("How many scores do you wish to enter?");
            string noScores = Console.ReadLine();
            int numScores = int.Parse(noScores);
            double avg1 = AvgUnkInts(0, 0, numScores);
            letterGrade = convertNumericToLetterGrade(avg1);
            Console.WriteLine($"The average of {numScores} is {avg1} and the letter grade is {letterGrade}");

            Console.WriteLine("\nPart 4, average non-predetermined number of scores.");
            Console.WriteLine("Enter a negative score to terminate the program.");
            (double avg2, int count) = AvgAnyInts(0, 0);
            letterGrade = convertNumericToLetterGrade(avg2);
            Console.WriteLine($"The average of inputed integers is {avg2}, count is {count} and the letter grade is {letterGrade}");
        }

        private static char convertNumericToLetterGrade(double grade)
        {
            char letterGrade = 'X';
            if (grade >= 90)
                letterGrade = 'A';
            else if (grade < 90 && grade >= 80)
                letterGrade = 'B';
            else if (grade < 80 && grade >= 70)
                letterGrade = 'C';
            else if (grade < 70 && grade >= 60)
                letterGrade = 'D';
            else if (grade < 60)
                letterGrade = 'F';
            return letterGrade;
        }

        private static (double, int) AvgAnyInts(double sum, int count)
        {
            Console.WriteLine($"Enter your Score: ");
            string sv1 = Console.ReadLine();
            sum += double.Parse(sv1);
            int input = int.Parse(sv1);
            count++;
            if (input < 0)
                return ((sum - input) / (count - 1), count);
            else
                return AvgAnyInts(sum, count);
        }

        private static double AvgUnkInts(double sum, int count, int numScores)
        {
            Console.WriteLine($"Enter your Score: ");
            string sv1 = Console.ReadLine();
            sum += double.Parse(sv1);
            count++;
            if (count < numScores)
                return AvgUnkInts(sum, count, numScores);
            else
                return sum / numScores;
        }

        private static double AvgTenInts(double sum, int count)
        {
            Console.WriteLine($"Enter your Score: ");
            string sv1 = Console.ReadLine();
            sum += int.Parse(sv1);
            count++;
            if (count < 10)
                return AvgTenInts(sum, count);
            else           
                return sum / 10.00;
        }

        private static int sumTenInts(int sum, int count)
        {
                Console.WriteLine("Enter your score: ");
                string sv1 = Console.ReadLine();
                sum += int.Parse(sv1);
                count++;
                if (count < 10)
                    return sumTenInts(sum, count);                           
                else
                    return sum;
        }
    }
}
