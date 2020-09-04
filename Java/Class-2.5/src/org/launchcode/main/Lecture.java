package org.launchcode.main;

public class Lecture {

	/**
	 * Class 2.5 - 1/22/2020 - Chapter 6 Unit Testing - Hank DeDona
	 * 
	 * @param args arguments passed into app at runtime
	 */
	public static void main(String[] args) {
		// Testing (unit testing in this case) is very important (and sadly often
		// overlooked)! :(

		// TDD - Test driven development, basically writing your tests first (that fail)
		// and then writing your code until all your tests pass :)
		// Note: great in theory, hard in practice.
		
		// Testing is important, finding bugs earlier in the development process costs less
		// than finding bugs later. The later you find them the more it costs. 
		
		
		// Testing best practices
		/*
		 * The AAAs
		 * 
		 * The AAAs of unit testing refers to the pattern to follow when writing your
		 * unit tests.
		 * 
		 * 1) Arrange the variables your test requires 
		 * 2) Act on the methods your test requires 
		 * 3) Assert the anticipated comparison of the expected and actual values
		 */
		
		// Deterministic
		// Every, single, solitary time a test is run, it should produce the same outcome.
		// A test that passes only most of the time is a worthless test.
		
		// Relevant
		// Tests, as they are written, should be grouped by related class and function. (Also SRP)
		
		// Meaningful
		// For example, unless they contain additional functionality, there is no need to write tests for getters and setters

		// See Classes Car and CarTest
		Car car = new Car("Toyota", "Prius", 10, 50);
		System.out.println(car.getMake() + " - " + car.getModel());
	}
}
