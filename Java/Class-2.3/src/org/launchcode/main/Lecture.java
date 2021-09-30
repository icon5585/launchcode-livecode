package org.launchcode.main;

public class Lecture {

	/**
	 * Class 2.3 - Chapter 4 Classes in Java Part 1- Hank DeDona
	 * 
	 * @param args arguments passed into app at runtime
	 */
	public static void main(String[] args) {

		// 4.1 Classes for Java
		section41classes();

		// 4.2 Modifiers in Java
		section42modifiers();

		// 4.3 Encapsulation
		section43encapsulation();

		// 4.4 Constructors
		section44constructors();

		// 4.5 Methods
		section45methods();

		// 4.6 SRP
		section46SRP();
	}

	/**
	 * Section 4.1 - Classes for Java
	 */
	private static void section41classes() {
		// See class HelloWorld and HelloWorldRunner
	}

	/**
	 * Section 4.2 - Modifiers
	 */
	private static void section42modifiers() {
		// Continue in HelloWorld
	}

	/**
	 * Section 4.3 - Encapsulation
	 */
	private static void section43encapsulation() {
		// See Student class and Temperature class

		// Encapsulation allows us to pair data with functions to manipulate that data

	}

	/**
	 * Section 4.4 - Constructors
	 */
	private static void section44constructors() {
		// 4.4 Constructors
		HelloWorld goodbye = new HelloWorld();
		goodbye.sayHello();

		// 4.4.1 Overloading constructors
		// See student class about overloading constructors
	}

	/**
	 * Section 4.5 - Methods
	 */
	private static void section45methods() {
		// 4.5 Methods
		// Methods belong to classes, period.

		// 4.5.1 Calling Methods on Objects
		HelloWorld hello = new HelloWorld(); // Instantiate new object
		hello.sayHello(); // Call method on object

		// 4.5.2. Instance Methods
		// See student method studentInfo
		Student billy = new Student("Billy", 3, 16, 3.5);
		System.out.println(billy.studentInfo()); // Calling our new instance method on our billy object
	}

	/**
	 * Section 4.6 - Single Responsibility Principle
	 */
	private static void section46SRP() {
		/*
		 * The single responsibility principle states that every module or class should
		 * have responsibility over a single part of the functionality provided by the
		 * software, and that responsibility should be entirely encapsulated by the
		 * class.
		 */

		// Basically what they're trying to say is that every class should do one thing
		// and one thing only!
		// If you're mixing and matching code, you should probably break them up into
		// two classes.

		// https://en.wikipedia.org/wiki/Single_responsibility_principle
	}

}
