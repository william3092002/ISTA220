# File: C# Homework 10
# Name: William Chan
# Date: 3 August, 2020

1. What does an array look like in memory?
	* The items in an array live in a contiguous
block of memory and are accessed by using an index, unlike fi elds in a structure or class, which are
accessed by name.
2. Where is memory allocated to hold an array, on the stack or on the heap?
	* Heap
3. Where is memory allocated to hold an array reference, on the stack or on the heap?
	* stack
4. Can an array hold values of different types? This is a trick question, the answer is, “It depends.” What
determines the types that an array can hold?
	* whether you implicitly or explicitly declare the type of array.
	* unless it hold objects 
5. Describe the syntax of the condition for a foreach loop.
	* foreach(type variable in array_name) 
6. How do you make a deep copy of a array?
	* first you instantiate a new instance of array, then you use foreach loop to assign value in each original element to copied element.
	* array_name.CopyTo(copy_array_name, begin_index_number)
	* Array.Copy(original_array_name, copy_array_name, copy_array_name.Length)
7. What is the difference in the syntax between a multi-dimensional array and an array of arrays?
	* items[2, 3] vs items[2][3]
8. What is the difference in the uses for a multi-dimensional array and an array of arrays? In other words,
what determines whether you would use one as opposed to the other?
9. How do you “flatten” a multidimensional array? In other words, take something that looks like a
matrix


1 2 3
4 5 6
7 8 9

 and turn it into an array [1, 2, 3, 4, 5, 6, 7, 8, 9]? Write the code to do this in English.
	* int[,] twoDimesion = new int[3,3];
            int[] copy = new int[twoDimesion.Length];
            int x = 1;
            int n = 0;
            for (int y = 0; y < 3; y++)
            {
                for (int z = 0; z < 3; z++)
                {
                    twoDimesion[y, z] = x;
                    //Console.WriteLine(twoDimesion[y, z]);                  
                    copy[n] = x;
                    n++;
                    x++;
                }
            }
            foreach (var num in copy)
            {
                Console.WriteLine(num);
            }
10. (Thought question) When we use a for loop, we can change the values of the array elements inside
the loop. When we use a foreach loop, we cannot change the values of the arry elements inside the
loop. Why not? How is for different from foreach?
	* You have access to the iteration variable when using a for loop. Foreach gives you access to the values, for loops give you access to the memeory location, so you can actually change the value in that address. 