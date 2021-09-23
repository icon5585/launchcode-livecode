package org.launchcode.main;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Scanner;

public class Lecture {

	/**
	 * Class 2.2 - 1/8/2020 - Chapter 3 Control Flow and Collections - Hank DeDona
	 * 
	 * @param args arguments passed into app at runtime
	 */
	public static void main(String[] args) {
		// 3.1 - condititionals
		section31conditionals();

		// 3.2 - loops
		section32loops();

		// 3.4 - arraylist
		section34arrayList();

		// 3.6 - hashmap
		section36hashMap();
	}

	/**
	 * Section 3.1 - Conditionals
	 */
	public static void section31conditionals() {
		System.out.println("3.1.1. if Statements");
		System.out.println("3.1.2. if else");
		System.out.println("3.1.3. else if");

		Scanner in = new Scanner(System.in);
		System.out.println("Enter a grade: ");
		int grade = in.nextInt();

		/*
		 * If blocks require parenthesis and curly brackets for a block of code (sorry)
		 * Note: There is an exception, you CAN exclude the curly brackets for a single
		 * line of code following an if/else block, however, some coders don't like
		 * it...
		 */
		if (grade < 60) {
			System.out.println('F');
		} else if (grade < 70) {
			System.out.println('D');
		} else if (grade < 80) {
			System.out.println('C');
		} else if (grade < 90) {
			System.out.println('B');
		}
		// Note: no curly brackets ;)
		else
			System.out.println('A');


		System.out.println("3.1.4. switch Statements");
		/*
		 * Switch statements are cleaner versions of if/else if's when you have a lot of
		 * possible different checks, however, they only work on certain values (ints,
		 * enums, etc) and don't work on checking Strings.
		 */

		System.out.println("Enter an integer to represent a day of the week: ");
		int dayNum = in.nextInt();

		String day;
		switch (dayNum) {
		case 0:
			day = "Sunday";
			break;
		case 1:
			day = "Monday";
			break;
		case 2:
			day = "Tuesday";
			break;
		case 3:
			day = "Wednesday";
			break;
		case 4:
			day = "Thursday";
			break;
		case 5:
			day = "Friday";
			break;
		case 6:
			day = "Saturday";
			break;
		default:
			// in this example, this block runs if none of the above blocks match
			day = "Int does not correspond to a day of the week";
		}
		System.out.println("The day of the week that corresponds with your integer is: " + day);

		// Notice that each case has a break in it... This is necessary to avoid falling
		// through to the next case.
		System.out.println("3.1.4.1. Fallthrough");

		System.out.println("Enter an integer to represent a day of the week: ");
		dayNum = in.nextInt();

		switch (dayNum) {
		case 0:
			day = "Sunday";
		case 1:
			day = "Monday";
		case 2:
			day = "Tuesday";
		case 3:
			day = "Wednesday";
		case 4:
			day = "Thursday";
		case 5:
			day = "Friday";
		case 6:
			day = "Saturday";
		default:
			// in this example, this block runs even if one of the above blocks match
			day = "Int does not correspond to a day of the week";
		}
		System.out.println("The day of the week that corresponds with your integer is: " + day);

		// No matter what value you put in, you will always end up in the default case
		// if you don't add the break!
		
		// always make sure to close your scanners :)
		in.close();
	}

	/**
	 * Section 3.2 - Loops
	 */
	public static void section32loops() {
		System.out.println("3.2.1. for Loop");

		// This will print out 0 -> 9
		// Note: i++ is in incrementor, it basically means i = i + 1
		// for (start clause; stop clause; step clause)
		for (int i = 0; i < 10; i++) {
			System.out.println(i);
		}

		System.out.println("3.2.2. for-each Loop");

		// Iterate over any collection using a for-each loop
		int nums[] = { 1, 1, 2, 3, 5, 8, 13, 21 };

		for (int i : nums) {
			System.out.println(i);
		}

		// Question: Why use an old for loop over a for each loop?

		// Also works for a string
		String msg = "Hello World";

		for (char c : msg.toCharArray()) {
			System.out.println(c);
		}

		System.out.println("3.2.3. while Loop");
		// No guarantee that this will ever run
		// Evaluated at beginning
		int i = 0;
		while (i < 3) {
			System.out.println(i);
			i++;
		}

		System.out.println("3.2.4. do-while Loop");
		// Guarantee that this will run AT LEAST once
		// Evaluated at end
		int j = 0;
		do {
			System.out.println(j);
			j++;
		} while (j < 3);

		// Question: Will the while and do/while loops print the same numbers?

		System.out.println("3.2.5. Break Statements in Loops");
		// Breaking allows you to stop what you're doing in a loop and "break" out of it
		// without having to loop through the entire collection using the break keyword

		int[] someInts = { 1, 10, 2, 3, 5, 8, 10 };
		int searchTerm = 10;
		
		// Search and replace (find 10, replace with 50)
		/*
		for(int k=0; k < someInts.length; k++) {
			if (someInts[k] == searchTerm) {
				someInts[k] = 50;
			}
		}
		*/
		
		for (int oneInt : someInts) {
			if (oneInt == searchTerm) {
				System.out.println("Found it!");
				break;
			}
		}

		System.out.println("3.2.6. Continue Statements in Loops");
		// Breaks the current iteration of the loop, basically if you had a bunch more
		// code below the continue term, it would not be executed
		int[] diffInts = { 1, 10, 2, 3, 5, 8, 10 };
		int diffSearchTerm = 10;
		for (int oneInt : diffInts) {
			if (oneInt == diffSearchTerm) {
				System.out.println("Found it!");
				continue;
			}
			System.out.println("Not here");
		}

	}

	/**
	 * Section 3.4 - ArrayList
	 */
	public static void section34arrayList() {
		System.out.println("3.4. ArrayList");
		// Like arrays, arraylists must have a type (yay type safe languages)
		// We declare the type in angle brackets <>
		// The students names in this arraylist are stored using strings
		List<String> students = new ArrayList<>();

		// The students grades in this arraylist are stored using doubles
		// Note: You can only store objects in arraylists, not primitives :(
		List<Double> grades = new ArrayList<>();

		System.out.println("3.4.1. ArrayList Iteration");
		System.out.println("3.4.1.1. do-while");

		Scanner input = new Scanner(System.in);

		// Get student names
		String newStudent;
		System.out.println("Enter your students (or ENTER to finish):");
		do {
			newStudent = input.nextLine();

			if (!newStudent.equals("")) {
				students.add(newStudent);
			}

		} while (!newStudent.equals(""));

		System.out.println("3.4.1.2. for-each");

		// Get student grades
		for (String student : students) {
			System.out.print("Grade for " + student + ": ");
			Double grade = input.nextDouble();
			grades.add(grade);
		}

		input.close();

		System.out.println("3.4.1.3. for");
		// Print class roster
		System.out.println("\nClass roster:"); // Note: the \n is a special character for a new line

		double sum = 0.0;
		// students.size() is the size of the arraylist, commonly used when looping
		// through an arraylist
		// Note: arraylists are 0 based
		for (int i = 0; i < students.size(); i++) {
			System.out.println(students.get(i) + " (" + grades.get(i) + ")");
			sum += grades.get(i); // Note: += is equivalent to sum = sum + grades.get(i);
		}

		// Print out average
		double avg = sum / students.size();
		System.out.println("Average grade: " + avg);

		System.out.println("3.4.2. ArrayList Methods");	
		List<String> planets = new ArrayList<>();
		planets.add("Mercury");
		planets.add("Venus");
		planets.add("Earth");
		planets.add("Mars");
		planets.add("Jupiter");
		planets.add("Saturn");
		planets.add("Uranus");
		planets.add("Neptune");

		System.out.println(planets.size());
		System.out.println(planets.contains("Earth"));
		System.out.println(planets.indexOf("Jupiter"));

		// Should be unsorted
		System.out.println(planets);

		Collections.sort(planets);

		// Should be sorted
		System.out.println(planets);

		// Arraylist -> array
		String[] planetsArray = new String[planets.size()]; // Arrays have to be of the correct size
		planets.toArray(planetsArray);
		
		// Create and populate array list in one line
		List<String> places = Arrays.asList("Buenos Aires", "Córdoba", "La Plata");
		
		List<Integer> intsFun = Arrays.asList(5,6,7);
		
		// Multi-dimension arrays
		int[][] stuff = new int[5][5];
	}

	/**
	 * Section 3.6 - HashMap
	 */
	public static void section36hashMap() {
		System.out.println("3.6. HashMap");
		// Hashmaps allow us to store key/value pairs
		// Hashmaps are actually just a specific implementation of the map interface

		// Note: You should use the map interface as the declaration type and the
		// hashmap implemtation as the instantiation type.
		Map<String, Double> students = new HashMap<>();

		// This declares a map with a KEY of type String and a VALUE of type Double
		// Again note, no primitives here :( only objects

		// Add a students grade to the map
		students.put("Billy", 80.0);

		// Add another students grade to the map
		students.put("Jesse", 90.0);

		// Get Billy's grade from the map
		Double billysGrade = students.get("Billy");
		System.out.println("Billy's grade is: " + billysGrade); // Should get 80.0

		Double sum = 0.0;
		// Looping through a map (yes it can be done)

		// Map.Entry represents a single entry in a map, it must be of the same type as
		// the entries in the map
		for (Map.Entry<String, Double> student : students.entrySet()) {
			System.out.println(student.getKey() + " (" + student.getValue() + ")");
			sum += student.getValue();
		}

		System.out.println("The sum of the grades is: " + sum);

		// You can also just get the keys or just the values using the keyset and values
		// and loop over them as well
		System.out.println(students.keySet());
		System.out.println(students.values());

		System.out.println("3.6.1. HashMap Methods");
		Map<String, Integer> moons = new HashMap<>();
		moons.put("Mercury", 0);
		moons.put("Venus", 0);
		moons.put("Earth", 1);
		moons.put("Mars", 2);
		moons.put("Jupiter", 79);
		moons.put("Saturn", 82);
		moons.put("Uranus", 27);
		moons.put("Neptune", 14);

		System.out.println(moons.size());
		System.out.println(moons.keySet());
		System.out.println(moons.values());
		System.out.println(moons.containsKey("Earth"));
		System.out.println(moons.containsValue(79));
	}

}
