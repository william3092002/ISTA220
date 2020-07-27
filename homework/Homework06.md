# File: C# Homework 6
# Name: William Chan
# Date: 20 July, 2020

1. What is an exception?
	* error that occur during application execution.
2. What happens in a try block if the program executes without errors?
	* the program will run normally, one line after another until the last line.
3. How does the catch mechanism work for unhandled exceptions?
	* if unhandled exception occurs and the try block is part of the method, the method immediately exits and execution returns to the calling method. 
	* if the calling method uses a try blockm the runtime attempts to locate and execute a matching catch handler for this try block. 
	* if the calling method does not use a try block or if there is no matching catch handler, the calling method immediately exits, and exits, and execution returns to its caller, where the process is repeated. 
	* if a matching catch handler is eventually found, the handler runs and execution continues with the first statement that follows the catch handler in the catching method.
	* if, after cascadomg back through the list of calling methods, the runtime is unable to find a matching catch handler, the program will terminate with an unhandled exception.
4. What happens in a program if an exception block fails to handle an particular error?
	* the program will terminate with an unhandled exception.
5. What is the parent class for all exceptions? How does this work?
	* the parent class of all exception is Exception. 
	* include a catch (exceptio ex) at the end of your catch statements.
6. How do you determine the type of an error?
	* run your application in debug mode and an exceotion occurs, a dialog box will show and contain the information that will help you determine the type of error.
7. What is the purpose of integer checking?
	* prevemt integer overflow
8. What is the range of values than a signed Int32 type can contain? State the lowest value and the
highest value.
	* -2,147,483,648 to 2,147,483,647
9. What is the range of values than an unsigned Int32 type can contain? State the lowest value and the
highest value. What is the difference between a signed integer and an unsigned integer? Can signed
integers and unsigned integers represent the same amount of numbers?
	* 0 to 4,294,967,295
	* signed integer covers postive and negative integers, unsigned integer only covers positive integer
	* they represent the same amout of numbers.
10. What does the finally block do?
	* ensure the code in the block will execute follow by the catch block.
11. (Thought question) When would you not use a finally block in a try/catch construction?
	* 


	

