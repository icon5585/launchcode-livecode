package org.launchcode.main;

import org.launchcode.main.cat.CatOwner;
import org.launchcode.main.cat.HouseCat;

public class Lecture {

	/**
	 * Class 2.6 - 1/29/2020 - Chapter 8 - Interfaces & Polymorphism - Hank DeDona
	 * 
	 * @param args arguments passed into app at runtime
	 */
	public static void main(String[] args) {
		// 8.1.1 Polymorphism
		HouseCat suki = new HouseCat("Suki", 12);
		
		// The CatOwner constructor takes in a "Cat" as it's parameter...
		// A HouseCat "is a" Cat so this works through Polymorphism
		CatOwner Annie = new CatOwner(suki);

		Annie.feedTheCat();
		
		// 8.2 Interfaces
		// Interfaces are like abstract classes without any implementations. Really, they're
		// like contracts that must be fulfilled by the classes that implement them.
		
		// See Feedable interface & Cat implementing it
		
		// 8.3 Interfaces Vs. Abstract Classes	
		// 1) Implement an interface, extend an abstract class
		// 2) Abstract classes may contain non-constant fields, while interfaces can only contain constant fields.
		// 3) Interfaces may only contain implementation code inside of default or static methods. Interfaces can't
		// contain methods that need to be shared by implementations, use an abstract class then if you want a 
		// "default implementation" of a method provided and allow your classes the option of overriding.
		
		// 8.4 Interfaces in Java
		// 8.4.1 Comparable<T> type	
		
		// 8.4.2 Comparator<T> type
		// Used when sorting, need to create a comparator in order to sort a list of items
		
		// 8.4.3 Iterable<T> type
		// Allows you to get an iterator and use for/each loops
		
		// 8.4.4 List<E> element
		// Just the List interface basically, allows for storage of elements in a list format
		
		// 8.4.5 Map<K, V> key, value
		// The map interface, allows for key/value pairs
	}
}
