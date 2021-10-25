package org.launchcode.main;

import java.util.ArrayList;
import java.util.List;

public class Lecture {

	/**
	 * Class 2.9 - Chapter X - Gradle & Exceptions - Hank DeDona
	 * 
	 * @param args arguments passed into app at runtime
	 */
	public static void main(String[] args) {
		// Gradle Stuff
		
		// Folder structure for gradle (as well as maven) apps
		// All code is in src/main/java/...
		// All tests are in src/test/java/...
		
		// All resources (anything not code), examples are xml files, pictures, config files, etc.
		// are stored in src/main/resoures for the main app and src/test/resources for tests
		
		// Gradle tasks (not all of them, but the 3 important ones for now)
		// Build -> build (assembles and tests the project)
		// Build -> assemble (assembles the output -> usually a war so you can bootRun) 
		// Application -> bootRun (runs the application in a container, in this case Tomcat)
		
		// Java version declaration - this is targeting java 13
		// sourceCompatibility = 13
		// targetCompatibility = 13
		
		// Declaring dependencies
		
		// The first part declares whether it's for the code (implementation) or tests (testImplementation)
		// The second part declares the dependency that you need 
		
		// implementation "joda-time:joda-time:2.2"
	    // testImplementation "junit:junit:4.12"
		
		// --------------------------------------------------------------------------------------------------------
		
		// What are exceptions?
		// When an error occurs within a method, the method creates an object and hands it off to the runtime system. 
		
		// Types of exceptions (technically 3, really only talk about 2)
		// Checked exceptions - Required to be caught or re-thrown. These MUST be handled by the developer, sometimes they can be recovered from.
		// Error - Exceptions that are external to the system and are not required to be caught or re-thrown
		// Runtime exceptions - Not required to be caught or re-thrown and are exceptional exceptions, usually nothing can be done if they occur.
		
		// For example... trying to use a null object throws a NullPointerException
		String nullString = null;
		
		try {
			nullString.charAt(0);
		} catch (NullPointerException e) {	// Note: This is a runtime exception
			e.printStackTrace();	// Prints out the stack trace of this exception
		}
		
		// Throwing your own exceptions
		// When writing your own apps, there will be a number of times when you'll want to throw exceptions
		
		// All exceptions extend from the class Throwable
		// Error and Exception extend Throwable
		// RuntimeException extends Exception
		
		// For example... taking in user input
		String userInput = "testInput";
		
		// Lets pretend that the user input must be at least 15 characters, and if it isn't, we throw an exception
		if(userInput.length() < 15) {
			throw new IllegalArgumentException("User input string must be at least 15 characters long!");
		}
		
		// Another example
		List<String> emptyList = new ArrayList<>();
		
		// Throw an exception if a list is empty (which it is, since we just instantiated it above)
		if(emptyList.isEmpty()) {
			throw new IllegalArgumentException("List cannot be empty!");
		}
		
		// Debugging... 
		// Very powerful, add breakpoints in your code and "step" through it. I've done it before in class and it 
		// helps in finding bugs in your code :)
		// Step over - step over the lines
		// Step into - step into the code/method
		// Step return - step back 
	}
}
