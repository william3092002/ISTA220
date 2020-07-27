# File: C# Homework 3
# Name: William Chan
# Date: 11 July, 2020

1. What is a method?
a method is a named sequence of statements, a method is a named block of code
1. What is the difference between a function and a procedure/subprocedure/subroutine?
methods returning values after processing are called "functions", methods returning no value are called procedure/subprocedure/subroutine.
	* procedural code is ezsy to write, but HARD to understand, maintain and tends to be buggy.
	* functional code is hard to wrtie, but easy to understand, maintain and tends to make less errors.
1. What does a return statement do?
the return statement causes the method to finish, and control returns to the statement that called the method. It returns a value.
1. What is an expression bodied method?
an expression bodied method is a simplified form of method that comprise a single expression.
	* a return type 
1. What is the scope of a variable?
the scope of a variable is where the variable can be accessed. 
1. What is an overloaded method?
an overloaded method is a method that allows various sets of parameters.
1. How do you call a method that requires arguments?
methodName(arguments);
1. How do you write a method, that is, specify the method definition, that requires a parameter list?
private double methodName (typeOfData parameter), you begin with whether a method will pass an output, if so you have to declare the type of data it outputs, if not you can use void; then follow by the name of your method; parenthesis that specify if your method requires inputs, if so you will specify the data type and give a name to the parameter, if not just leave it blank.
1. How do you specify a parameter as optional when defining a method?
you specify a parameter as optional by assigning a defaul value to the parameter while you declare the method.
1. How do you pass a argument to a method as a named parameter?
you pass an argument to a method as a named parameter by specifying the name of the parameter, following by a colon and the value of your intent.
1. How do you return values from a method? Can you return multiple values from a method, and if so, how?
You return values from a method by using a return statement in the end of your method, call your method and assign it to a declared variable. You can return multiple values from a method by returning a tuple.
1. What is a tuple? How do you define a method that returns multiple values? Give an example of a method that returns multiple values other than the example in the book.
	* a tuple is simply a small collection of values. 
	* you specify the method returns multiple values by spefifying multiple types of return value when declaring your method.
	* (double, double) returnMultipleValues();
1. 	Examine the method definition on page 83 of the book. Desk check the execution of this method. What do you discover? This is called recursion
the statement of the method calls on itself
1. How does the compiler resolve an ambiguity between named arguments and optional parameters?
it depends on the situation. The complier can distinguish between methods by comparing argument names to the names of the parameters specified in the method declarations and select the method that has a parameter with a matching name. The complier can also distinguish between methods if they have different parameter lists. The compiler won't allow you to compile the application if there is an unresolvable ambiguity. 
1. The book states: “A key feature of C# and other languages designed for the .NET Framework is theability to interoperate with applications and components written with other technologies.” What is the COM and how is the CLR dependent on the COM?
COM is a method to facilitate communication between different applications and languages. 