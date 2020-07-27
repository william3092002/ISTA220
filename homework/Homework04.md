# File: C# Homework 4
# Name: William Chan
# Date: 11 July, 2020

1. What are all possible values of Boolean expression?
	* either true or false
1. List the equality operators. List the relational operators. List the logical operators. How are they the
same? How are they different?
	* equality operators: ==, !=
	* relational operators: <, <=, >, >=
	* logical operators: &&, ||, !
	* they are all boolean operators 
	* their precedence are different 
	
1. What is the general concept of short circuiting? This question has a short and simple answer and you
do not need to have a detailed response.
	* only the left hand side operand is evaluated
1. What are the difference in how short circuiting works for && and ||?
	* &&, if one operand is evaluated to be false, the boolean expression is evaluted to be false. 
	* ||, if one operand is evaluated to be true, the boolean expression is evaluated to be true.
1. Look at the list of operators. What operator has the highest precedence? Which has the lowest?
	* primary operator has the higest precedence (), post ++, post --
	* assignment operator has the lowest precedence
1. In an if or else construction using multiple lines of code, what effect does the use of curly braces have?
	* allow multiple statments to be included in that scope
1. In a switch statement, what happens if you omit break?
	* the application will not compile
1. The four keywords in a switch statement are switch, case, break, and default. Explain what each
keyword does.
	* switch: a method that accept controlling expression as an input. It is a boolean expression that's only evaluted once. It takes a variable to be evaluated. 
	* case: the value to be evaluated against the controlling expression.
	* break: to terminate a statement sequence.
	* default: the default statement is executed if no case constant-expression value is equal to the value of expression. 
1. Look at the source listing below. It contains two methods: recurr1() and recurr2(). There is a
significant difference between the two methods. What is it?
	* the recurr2 calls itself in the method body. Its a recursive method.  
1. (Not in book) What is a recursive method? Using a language you know (such as English), write a
recursive method that adds up the integers in a list of integers. The input to the method is a list of
integers and the output is a scalar value representing a sum.
	* A recursive method is a method that calls itself in the method body. 
	* long sum (int dataValue)
            {
                if (dataValue == 0)
                {
                    return 0;
                }
                else
                {
                    return dataValue + sum(dataValue - 1);
                }
            }
            long sumValue = sum(inputValue);
            return sumValue;
1. (Not in book) Read a short summary of De Morgan’s laws
	* The complement of the union of two sets is equal to the intersection of their complements and the complement of the intersection of two sets is equal to the union of their complements.
	* 
	
