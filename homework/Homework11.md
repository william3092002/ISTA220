# File: C# Homework 11
# Name: William Chan
# Date: 9 August, 2020

1. What is a parameter array?
	* is an array with indefinite number of argiments and each element of the array can be differnt types. 
2. How do you define a method that takes an arbitrary number of arguments?
	* use the params key word in your parameter.
3. How do you call a method that takes an arbitrary number of arguments?
	* by passing arbitraty number of arguments into your method. 
4. Why can’t you use an array to pass an arbitrary number of arguments to a method?
	* because you cannot declare an array without a definite number of elements for the array.
	* something to do with pointer arithmetic.
5. How many parameters can a method have?
	* as many as you like.
6. Do parameter arguments have to have the same type?
	* no
7. What is the difference between a method that takes a parameter argument and one that takes optional
arguments?
	* the method that takes optional parameters is not aware of which of the arguments are provided by the caller and which are compiler-generated defaults.
	* A method that uses a parameter array effectively has a completely arbitrary list of parameters,
and none of them has a default value. Furthermore, the method can determine exactly how
many arguments the caller provided.
8. How do you define a method that takes different (and arbitrary) types of arguments?
	* using params project[]
9. Write a method that accepts any number of arguments of a given type.
	* public static int methodName(params int[] paramList)
10. Write a method that accepts any number of arguments of any type.
	* public static void methodName(params object[] paramList)
