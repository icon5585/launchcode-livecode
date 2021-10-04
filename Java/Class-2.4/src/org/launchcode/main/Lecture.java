package org.launchcode.main;

public class Lecture {

	/**
	 * Class 2.4 - Chapter 5 Classes and Objects Part 2 - Hank DeDona
	 * 
	 * @param args arguments passed into app at runtime
	 */
	public static void main(String[] args) {
		// 5.1. Customizing Fields
		section51fields();

		// 5.2. Instance and static methods
		section52InstanceAndStatic();

		// 5.3. Special Methods
		section53SpecialMethods();
	}

	/**
	 * Section 5.1 - Customizing Fields
	 */
	private static void section51fields() {
		// 5.1.1. Final Fields
		// See class FinalFields

		// 5.1.2. Static Fields
		// See class Temperature

		// Accessing from outside of class
		Temperature temp = new Temperature();
		Temperature temp2 = new Temperature();
		Temperature temp3 = new Temperature();
		
		// Don't do this
		// Access static variables via the class, not the instance variable.
		System.out.println(temp.absoluteZeroFahrenheit);
		
		// Do this
		System.out.println(Temperature.absoluteZeroFahrenheit);
		
		// If the static field is public, we can do this - This is the correct way,
		// period.
		System.out.println("Absolute zero in F is: " + Temperature.absoluteZeroFahrenheit);

		// Or if we have an object named "temp" of type Temperature - Don't do this,
		// this is wrong!
		System.out.println("Absolute zero in F is: " + temp.absoluteZeroFahrenheit);

		// 5.1.3. Constants
		// See class constants
	}

	/**
	 * Section 5.2 - Instance and Static Methods
	 */
	private static void section52InstanceAndStatic() {
		// 5.2.2. Instance Methods
		// Refer to Student class
		Student billy = new Student("Billy", 7, 16, 3.6);
		
		// An example of an instance method (billy is an instance of class Student)
		System.out.println(billy.getGradeLevel());

		// 5.2.3. Static Methods
		// We've already used static methods (public static void main)
		// Refer to HelloMethods and Message classes

		// Note: You cannot access non-static methods from static methods...
	}

	/**
	 * Section 5.3 - Special Methods
	 */
	private static void section53SpecialMethods() {
		// 5.3.1. ToString
		Student person = new Student("Violet");
		
		// String representation of object
		// Note: If toString is not overridden, will display fully-qualified class name
		// @ memory address (not super helpful). You SHOULD always override your
		// toString methods to make them useful :)
		System.out.println(person.toString());

		// 5.3.2. Equals
		// Note: There are libraries that make this way easier, for example, 
		// apache commons has a equals and toString creator.
		// Equals allows for comparison of objects
		Student student1 = new Student("Maria", 1234);
		Student student2 = new Student("Maria", 1234);

		System.out.println(student1.name + ", " + student1.studentId + ": " + student1);
		System.out.println(student2.name + ", " + student2.studentId + ": " + student2);
		System.out.println(student1 == student2);	// Actually compares MEMORY addresses
		System.out.println(student1.equals(student2));	// Compares values
		
		// Components
		// Reflexivity: For any non-null reference value x, x.equals(x) should return true.
		// Symmetry: For any non-null reference values x and y, x.equals(y) should return true if and only if y.equals(x) also returns true.
		// Transitivity: For any non-null reference values x, y, and z, if x.equals(y) returns true and y.equals(z) returns true, then x.equals(z) should return true.
		// Consistency: As long as x and y do not change x.equals(y) should always return the same result.
		// Non-null: For any non-null reference value x, x.equals(null) should return false.
		
	}

}
