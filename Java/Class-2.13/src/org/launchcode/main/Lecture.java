package org.launchcode.main;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

import org.launchcode.main.animal.Animal;
import org.launchcode.main.animal.Cat;
import org.launchcode.main.animal.Dog;
import org.launchcode.main.files.DatabaseSaver;
import org.launchcode.main.files.FlatFileSaver;
import org.launchcode.main.files.Saveable;

public class Lecture {

	/**
	 * Class 2.13 - Catchup/Review - Inheritance and Polymorphism - Hank DeDona
	 * 
	 * @param args arguments passed into app at runtime
	 */
	public static void main(String[] args) {
		// Great YouTube video explaining the 4 pillars of OOP
		// https://www.youtube.com/watch?v=1ONhXmQuWP8
		
		// Inheritance and Polymorphism

		// Define difference between Class and Instance

		// Class
		// This is the model or standard about the capability of what an object can do

		// Instance
		// An actual implementation of the class, consider the class the blueprint and
		// the instance the result (object)

		// There are 4 pillars of object oriented programming

		// Encapsulation (Data Hiding)
		// Combining the data with the methods for working on that data. Encapsulation
		// is accomplished when each instance of a class maintains a private state. Instead of being able to
		// modify this state, in the form of private variables/properties, they can only be access and manipulated
		// (setters/getters) via public functions available to users.

		// Abstraction (Implementation Hiding)
		// The process of reducing the object to its essence so that only the necessary
		// data is exposed to the users. Through the use of interfaces, you can abstract out
		// the implementation completely.
		// Note: Both abstract classes and interfaces are used for abstraction!

		// Inheritance
		// The ability of one object to acquire some/all properties of another object.
		// You can reuse the variables/properties and methods of the existing class 
		// by inheriting it (extending). This enforces the DRY (don't repeat yourself)
		// principle and reduces code duplication.

		// Polymorphism
		// Allows us to use a class exactly like its parent so there is no confusion
		// with mixing types.
		// E.g. If we have a parent class of Animal, with child classes of Cat and Dog,
		// we can store all of these in a single collection (list) of Animals and call methods that
		// are present in Animal that must be implemented in Cat and Dog!
		// See Animal.java, Cat.java, and Dog.java
		showOffPolymorphism();

		// Interfaces vs abstract classes

		// Interfaces
		// Provide the contract for all classes that implement it. In other words, if
		// your class implements an interface
		// it is required to implement all of the methods defined in that interface.
		// This allows for easy swapping of implementations.
		// See Saveable.java, FlatFileSaver.java, and DatabaseSaver.java
		showOffInterfaces();

		// Abstract classes
		// An abstract class may or may not have all abstract methods. Some of them can
		// be concrete methods (implementations) where the method signature and body are
		// provided. Abstract classes can also have constructors (which are called by child
		// classes), that interfaces cannot have.
		// See Animal.java

		// When to use an abstract class Vs. interface
		// If there isn't much (or any) common code among all the child classes, use an
		// interface, otherwise use an abstract class to reduce code duplication.
		// When application functionalities have to be defined as a contract, but not
		// concerned about who implements the behavior.
		// i.e., third-party vendors need to implement it fully

		// Note: Your child class can implement multiple interfaces, but only extend one
		// class.

	}

	private static void showOffPolymorphism() {
		List<Animal> animals = new ArrayList<>();
		animals.add(new Cat());
		animals.add(new Dog());

		// Should say meow and woof in that order :)
		// Note: This is a Java lambda expression, shorthand for a for-each loop in this
		// case
		animals.stream().forEach(a -> a.animalSound());

		// Polymorphism
		// Since Cat and Dog both inherit from Animal
		for (Animal animal : animals) {
			// Animal -> Cat
			if (animal instanceof Cat) {
				Cat cat = ((Cat) animal);

				// Should say "nom, lasagna!"
				cat.eatLasagna();
			}
			// Animal -> Dog
			else if (animal instanceof Dog) {
				Dog dog = ((Dog) animal);

				// Should say "I'm gonna get the squirrel!";
				dog.chaseSquirrel();
			}
		}
	}
	
	private static void showOffInterfaces() {
		{
			// Doing some awesome code here
			Scanner input = new Scanner(System.in);
			System.out.print("Give me some stuff to save: ");
			String stuffToSave = input.nextLine();
			System.out.print("How would you like to save it? 1 for flat file, 2 for database");
			Integer choice = input.nextInt();
			
			
			// Note: We might not actually give the user a choice, we might swap out the
			// saveable implementation without them knowing. This will become more evident when we talk
			// about context and dependency injection.
			Saveable saver = null;
			switch (choice) {
			case 1: {
				saver = new FlatFileSaver();
				break;
			}
			case 2: {
				saver = new DatabaseSaver();
				break;
			}
			default:
				input.close();
				throw new IllegalArgumentException("Unexpected value: " + choice);
			}
			
			saver.saveStuff(stuffToSave);
			
			input.close();
			
		}
	}
	
}
