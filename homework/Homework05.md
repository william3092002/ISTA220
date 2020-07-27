# File: C# Homework 5
# Name: William Chan
# Date: 18 July, 2020

1. What is a compound assignment operator? How does it work?
	* it combines the function of both assignment and operator
	* assignment operator operate on both operands and assign the new value to the left operand. 
2. List all the compound assignment operators.
	* +=, -=, *=, /=, %=
3. List two ways to increment a numeric variable by 5. List two ways to decrement a numeric variable by 50.
	* int x = x + 5; int x += 5;
	* int y = y -50; int y -= 50;
4. How long does a while loop run?
	* as long as the boolean expression is evaluted to true.
5. What is an iteration variable? (Not in book)
	* the variable that is changed each iteration of the loop. Something that you testing. 
6. What happens if you don’t change the loop variable in the body of the while loop block?
	* the loop will go on until stack overflow. 
7. How many parts does a for loop statement have? Can you omit any of them? Can you omit all of them? What happens if you omit all of them?
	* three parts: initialization, boolean expression, iteration variable update
	* yes you can omit any or all of them. You will have to include them in the body of your loop or you will get an infinite loop.
8. How do you guarantee that a loop runs at least once?
	* use DO keyword.
9. What does the break statement do?
	* it terminates the loop and move on to the next statment follow by the loop.
10. What does the continue statement do?
	* continue will skip the current iteration and continue the execution of the loop.
11. (Thought question) Can you think of any reason why you would want to have an infinite loop? An
“infinite loop” is a loop without an update variable that in effect runs forever. As you will see, these
kinds of loops are written intentionally to perform various kinds of tasks.
	* a application that keeps time. 
	* web server
	while (true)
	{
		listen_for_incoming_HTTPS_request();
		handle_incoming_HTTPS_request();
	}

	


