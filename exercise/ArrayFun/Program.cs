using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05_william
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is part 1");
            int[] arrayA = { 0, 2, 4, 6, 8, 10 };
            int[] arrayB = { 1, 3, 5, 7, 9 };
            int[] arrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };


            meanArr(arrayA);
            meanArr(arrayB);
            meanArr(arrayC);
            Console.WriteLine();

            Console.WriteLine("This is part 2");
            Console.Write($"The reverse of arrayA is: ");
            reverseArr(arrayA);
            Console.Write($"The reverse of arrayB is: ");
            reverseArr(arrayB);
            Console.Write($"The reverse of arrayC is: ");
            reverseArr(arrayC);
            Console.WriteLine();

            Console.Write("This is part 3\n");
            string direction = "left";
            int rotatNum = 2;
            Console.WriteLine($"If you rotate arrayA to the {direction} by {rotatNum} place you get a new array like this: ");
            rotatArr(arrayA, direction, rotatNum);
            direction = "right";
            rotatNum = 2;
            Console.WriteLine($"If you rotate arrayB to the {direction} by {rotatNum} place you get a new array like this: ");
            rotatArr(arrayB, direction, rotatNum);
            direction = "left";
            rotatNum = 4;
            Console.WriteLine($"If you rotate arrayC to the {direction} by {rotatNum} place you get a new array like this: ");
            rotatArr(arrayC, direction, rotatNum);
            Console.WriteLine();

            Console.WriteLine("This is part 4");
            Console.Write("The sorted arrayC is: ");
            //int[] arrayD = { 21, 5, 66, 898, 78, 0, 2, 5, 66, 3, 5 };
            sortArr(arrayC);
            //sortArr(arrayD);
            

        }

        private static void sortArr(int[] array)
        {
            int count = 1;
            int remainArrDiff = 0;
            Console.Write("{ ");
            for (int j = 0; j < array.Length; j++)
            {
                if (count >= array.Length)
                    count = j + 1;
                remainArrDiff++;
                for (int i = 0; i < array.Length - remainArrDiff; i++)
                {
                    if (array[j] > array[count])
                    {
                        int temp = array[j];
                        array[j] = array[count];
                        array[count] = temp;
                    }
                    count++;
                }
                Console.Write(array[j]);
                if (j != array.Length - 1)
                    Console.Write(", ");
            }
            Console.Write(" }\n");
        }

        private static void rotatArr(int[] array, string direction, int rotatNum)
        {
            int[] copy = new int[array.Length];
            int count1;
            int length = array.Length;
            int startIndx = 0; 
            
            if (direction == "right")
            {
                startIndx = length - (rotatNum % length);
                if (startIndx == length)
                    startIndx = 0;
            }
            if (direction == "left")
            {
                startIndx = rotatNum % length;
                if (startIndx == length)
                    startIndx = 0;
            }
            Console.Write("{ ");
            for (count1 = 0; count1 < length; count1++)
            {
                    copy[count1] = array[startIndx];
                    startIndx++;
                    if (startIndx > array.Length - 1)
                        startIndx = 0;
                    Console.Write($"{copy[count1]}");
                    if (count1 != array.Length - 1)
                        Console.Write(", ");
            }
            Console.Write(" }\n");
        }

        private static void reverseArr(int[] array)
        {
            int[] copy = new int[array.Length];
            int count1 = 0;
            int count2 = array.Length - 1;
            string name = $"{array}";
            Console.Write("{ ");
            for (count1 = 0; count1 < array.Length; count1++)
            {
                copy[count1] = array[count2];
                count2--;
                Console.Write($"{copy[count1]}");
                if(count1 != array.Length-1)
                Console.Write(", ");
            }
            Console.Write(" }\n");
        }

        private static void meanArr(int[] array)
        {
            double sum = 0;
            double result;          
            int count;
            for (count = 0; count < array.Length; count++)
            {
                sum += array[count];
            }
            result = sum / count;

            Console.WriteLine($"The sum of array A is {sum}, the count is {count} and the mean is {result}");

        }
    }
}
