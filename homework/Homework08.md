# File: C# Homework 8
# Name: William Chan
# Date: 27 July, 2020

1. What is the difference between deep copy and shallow copy?
	* Deep copy is when all the reference type provides a Clone method, shallow copy is when the clone method simply copies references.
	* shallow copy copies only the reference, deep copy copies what the reference points to.
2. What is the value of a reference after you declare and initialize it?
	* the address of the object it refers to on the heap
3. How do you declare a value type?
	* int x = 0; 
4. How do you declare a reference type?
	* circle c = new circle(); 
5. Does C# allow you to assign NULL to a value type?
	* no, only to a nullable value type
6. Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?
	* no, because a nullable value type might have a null value, and you cannot assign null value to a non-nullable value type
7. What is the difference between the stack and the heap?
	* stack memory is like a stack of boxes piled on top of one another. 
	* heap memory is likea a large pile of boxes strewn around a room rather than stacked neatly on top of one another.
8. What does it mean when we say that all classes are specialized types?
	*  For the time being, simply
accept that all classes are specialized types of System.Object and that you can use System.Object to
create a variable that can refer to any reference type.
9. What does ref do?
	* it allows you to modify the value of an argument passed to the method through the method's parameter
10. What does out do?
	* it allows you to initialze parameters through the method. 
11. Describe boxing and unboxing in your own words.
	* it creates an instance for the reference type, which contains a copy of the value of the value type.
	* it retrieves a copy of the value in an instance and store it in a value type variable. 
	* when you box you turn a value type into a reference type, when you unbox you take a reference type and turn it into a value type.
12. What does cast do?
	* This is an operation
that checks whether converting an item of one type to another is safe before actually making the copy.
	* it converts between types