package org.launchcode.main;

import java.util.Scanner;

public class Lecture {

	public static void main(String[] args) throws CloneNotSupportedException {

		// Single line comment
		/*
		 * Block comment
		 */

		System.out.println("2.1.1. Static vs. Dynamic Typing");
		/*
		 * Java is a statically typed language. When a variable or parameter is declared
		 * in a statically typed language, the data type for the value must be
		 * specified. Once the declaration is made, the variable or parameter cannot
		 * refer to a value of any other type
		 */
		String myDogsName = "Milo";

		// Nope!
		// myDogsName = 42; // This is trying to store an int in a String, legal in
		// javascript, not in java

		System.out.println("2.1.2.2. Single vs. Double Quotation Marks");
		String staticVariable = "dog"; // String
		char charVariable = 'd'; // Single Char
		// Nope!
		// charVariable = 'ab';

		System.out.println("2.1.2.3. String Manipulation");
		String str = "Rutabaga";
		System.out.println(str.charAt(3));
		System.out.println(str.substring(2, 4));
		System.out.println(str.length());
		int startIndex = (str.indexOf('a')+1);
		System.out.println(str.indexOf('a', startIndex));

		System.out.println("2.1.3. Primitive Types");
		int answerToAllThings = 42;
		float pi = 3.141593f; // Note: need to add an f at the end of floats!
		double piDouble = 3.14159265358979;
		boolean iAmTrue = true;

		System.out.println("2.1.4. Non-primitive Types");
		String cool = "LaunchCode";

		System.out.println("2.1.5. Autoboxing");

		// Autoboxing primitive -> object
		int somePrimitiveInteger = 5;
		Integer someIntegerObject = somePrimitiveInteger;

		// Autounboxing object -> primitive
		int someNewPrimitiveInt = someIntegerObject;

		System.out.println("2.2.6. Collect Input with the Scanner Class");
		Scanner input = new Scanner(System.in); // System.in is from the console (user input)
		System.out.print("Enter the temperature in Fahrenheit: ");
		double fahrenheit = input.nextDouble();	// Wait for user input
		double celsius = (fahrenheit - 32) * 5 / 9;

		System.out.println("The temperature in Celsius is: " + celsius);

		input.close();	// Close the scanner!!

		System.out.println("2.3.1. Arrays");
		// Array of 10 ints (empty array)
		int[] someInts = new int[10];

		// Initialize an array with 6 values on a single line (1,1,2,3,5,8)
		int[] someOtherInts = { 1, 1, 2, 3, 5, 8 };

		// To access the data in the array someOtherInts, we use square brackets
		int someVal = someOtherInts[4]; // This will store 5 in someVal

		System.out.println("2.3.2. Java Objects");
		System.out.println("Repeat after me, everything that is not a primitive is an object in Java!");
		System.out.println("Everything that is not a primitive is an object in Java!");

		String language = "Java";

		// The String class is an object, we can call methods on objects.
		System.out.println(language.length()); // This will print the length of the string language (in this case 4)

		System.out.println("2.3.3. Class Types");
		/*
		 * A class is a template for creating objects. In addition to the object types
		 * introduced so far, any class in Java also defines a type. We’ll have much
		 * more to say about classes and objects, but for now you need to recognize the
		 * basic syntax of class types and class creation.
		 */
		
		// Create an instance of the Cat class called myDefaultCat using the NEW keyword
		// 1) Cat myDefaultCat declares the variable myCat and sets it to be of type Cat.
		// 2) = new Cat() initializes the variable with a new Cat object.
		// 3) Any arguments that are required to build the new Cat object must be included within the parentheses.
		Cat myDefaultCat = new Cat();
		
		Cat myNamedCat = new Cat("KitKat");	// Including values within the parenthesis
		
		System.out.println("2.3.3.1. Reference Variables");
		
		int firstCatAge = 11;
		int secondCatAge = firstCatAge;	// firstCatAge and secondCatAge are separate values (11)
		
		Cat myCat = new Cat("buster");
		Cat sameCat = myCat;	// myCat and sameCat point to the same values in memory
		
		System.out.println("MyCat name: " + myCat.getName());
		System.out.println("SameCat name: " + sameCat.getName());
		
		myCat.setName("blah");
		
		System.out.println("MyCat name: " + myCat.getName());
		System.out.println("SameCat name: " + sameCat.getName());
		
		// Lets make sameCat the same VALUE (pass by value, NOT reference!)
		
		Cat cloneCat = myCat.clone();
		
		cloneCat.setName("Clonie");
		
		System.out.println("MyCat name: " + myCat.getName());
		System.out.println("Clonecat name: " + cloneCat.getName());
		
		System.out.println("2.3.4. Static Methods");
		// Static methods can be called on a class directly without instatiating a variable first
		Cat.makeNoise();	// Cat is the class, not an object (like myCat or sameCat)
	}

}
