package org.launchcode.main;

import org.launchcode.main.cat.Cat;
import org.launchcode.main.cat.HouseCat;

public class Lecture {

	/**
	 * Class 2.6 - Chapter 7 - Inheritance - Hank DeDona
	 * 
	 * @param args arguments passed into app at runtime
	 */
	public static void main(String[] args) {
		// 7.2 Inheritance in Java
		// Relationship between two classes, Cat and HouseCat
		// HouseCat extends Cat, in other words HouseCat is a subclass of Cat

		// Remember our access modifiers..
		// HouseCat has access to any public or protected variables/methods of Cat

		// 7.3.1 - Inheriting fields/properties/methods
		HouseCat garfield = new HouseCat("Garfield", 12);
		
		// HouseCat class doesn't have an eat method, but Cat class does! (inheritance
		// at work)
		garfield.eat();
		
		// prints true
		System.out.println(garfield.isTired());

		// 7.3.2 - Super
		HouseCat mittens = new HouseCat(8.4);
		// Super calls the constructor of the parent class (see HouseCat constructor)
		// Also note that the super() - default constructor - is called by default

		// 7.3.3 @Override
		// A new annotation!

		// When extending a class, occasionally we want to modify or override the
		// behavior provided by the parent class, when we do, we use the @override annotation!
		
		// See: Cat and HouseCat classes noise() method
		// Both Cat and HouseCat class have a noise() method
		
		Cat plainCat = new Cat(8.6);
		HouseCat cheshireCat = new HouseCat("Cheshire", 12);

		System.out.println(plainCat.noise()); // prints "Meeeeeeooooowww!"
		System.out.println(cheshireCat.noise()); // prints "Hello, my name is Cheshire!"
		
		// 7.4.1 Abstract classes
		// Abstract classes allow for "base" classes where you have a lot of shared functionality.
		// However, when you have an abstract class you cannot instantiate an instance of that class!
		
		// For example, if we make the Cat class abstract, we can no longer do the following:
		// Cat salem = new Cat(8);
		
		// 7.4.2 Abstract methods
		// Just as we can have abstract classes, we can have abstract methods. Abstract methods are different
		// than abstract classes though. Abstract methods are more like interface methods in that they only have
		// a method signature, no body and MUST be implemented by any sub-classes.
		
		// 7.5 Casting
		// When one class extends another, as HouseCat extends Cat, a field or local variable of the type of 
		// the base class may hold an object that is of the type of the child class.
		Cat suki = new HouseCat("Suki", 8);
		suki.eat();
		System.out.println(suki.noise()); // Hello, my name is Suki!
		 

		// Remember, as far as it knows, it's declared as a Cat, instantiated as a HouseCat
		// Side note: Most developers create interfaces that have all declared methods and have implementations
		// that implement them, so this doesn't become a problem.
		// suki.isSatisfied();			// doesn't have such a method
		
		// As long as suki really is a HouseCat, this works by Casting it to the right class 
		// and calling the method on it!
		
		// Something I would do...
		if (suki instanceof HouseCat) {
			// safely cast
			((HouseCat) suki).isSatisfied();
		}
		
		// 7.6 - Testing inheritance
		// See CatTest
		
		// Lets do some checking on your learning :)
		Cat baseCat = new Cat(5.0);
		HouseCat houseCat = new HouseCat(10.0);
		

		if(baseCat instanceof Cat) {
			// This better be true
			System.out.println("Cat is an instance of Cat");
		}
		
		if(baseCat instanceof HouseCat) {
			// True or false?
			System.out.println("Cat is an instance of HouseCat");
		}
		
		if(houseCat instanceof Cat) {
			// True or false?
			System.out.println("HouseCat is an instance of Cat");
		}
		
		if(houseCat instanceof HouseCat) {
			// True or false?
			System.out.println("HouseCat is an instance of HouseCat");
		}
	}
}
