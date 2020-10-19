# File: C# Homework 12
# Name: William Chan
# Date: 10 August, 2020

1. How does inheritance promote the principle of don’t repeat yourself (DRY)?
	* You can declare a method once in the base class and all derived classes have access to it.
2. What is the syntax of a derived class that inherits from a base class?
	* class derived_class_name : base_class_name
3. Do all user defined types (classes and structs) inherit from some base class? If so, what is it?
	* all classes inherit from System.Object class
	* all structs inherit from an abstract class named System.ValueType
4. What happens if you do not have a default constructor in a base class when creating a derived class?
	* result in compile time error
5. Can you assign a variable of a derived class to another variable of its base class? Why or why not?
	* yes, mammal myMammal = myHorse, a horse is a mammal. So a horse can be assigned to the mammal class.
6. Can you assign a variable of a derived class to another variable of a derived class of its base class?
Why or why not?
	* no, whale myWhale = myHorse. They are different types. 
7. Can you assign a variable of a base class to another variable of a derived class? Why or why not?
	* no, Horse myHorse = myMammal; not all mammal objects are horses. You can assign a base variable to a derived class by using the is and as operatoers and cast.
8. Under what circumstances would you want to use the new keyword when defining a method in a
derived class?
	* when you want to override the warnning message of hiding the base method
9. What is a virtual method? Why would you want to define a virtual method?
	* a virtual method is a method that can be overriden in its derived class. So you can override it to fit a specific use case.
10. What does override do? Why does it do it?
	* it supercedes the base virtual method. So you have another option when the base virtual method doesn't meet your needs.  
11. How do you define an extension type?
	* use this key word in the parameter 
12. Why do you define an extension type?
	*  you can extend an existing type (a class or structure) with additional
static methods.
13. (Not in book) Explain the Liskov substitution principle.