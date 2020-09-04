package org.launchcode.main;

public class Lecture {

	/**
	 * Class 2.12 - 2/17/2020 - Chapter 13 & 14 - Models Validation & Enums - Hank DeDona
	 * 
	 * @param args arguments passed into app at runtime
	 */
	public static void main(String[] args) {
		// Chapter 13 - Model validation
		chapter13();
		
		// Chapter 14 - Enums
		chapter14();
	}
	
	private static void chapter13() {
		// 13.1 - Server side validation
		// This is validation of user input that is done via Java code
		
		// Vs. client side validation
		// Validation done in the browser Javascript, etc.
		
		// 13.2 - Validation Annotations
		
		// @Size(min = 3, max = 12)
		// Specifies minimum and/or maximum length for a string, 3 min, 12 max characters in this example.
		
		// @Min(0)
		// Specifies the minimum value of a numeric field, i.e. only positive numbers
		
		// @Max(365)
		// Specifies the maximum value of a numeric field.
		
		// @Email
		// Specifies that a string field should conform to email formatting standards.
		// Note: This can be done using regular expressions and am willing to guess that's what it's doing behind the scenes.
		
		// @NotNull
		// Specifies that a field may not be null.	
		
		// @NotBlank
		// Specifies that a string field contains at least one non-whitespace character.
		
		// Example: This says that the string, username, must not be blank and be between 3 and 12 characters.
		/*  @NotBlank
			@Size(min = 3, max = 12)
 			private String username;
		 */
		
		// 13.2.2 - Validation messages
		// You're allowed to define user-friendly error messages for when validation fails.
		
		// Examples:
		// @NotBlank(message = "Username is required")
		// @Size(min = 3, max = 12, message = "Username must be between 3 and 12 characters long")
		
		// Refer to Event.java in coding-events project
		
		// Note: all of the annotations for constraints are here: https://javaee.github.io/javaee-spec/javadocs/javax/validation/constraints/package-summary.html
		
		// This is only the model validation portion, in order for us to get the "whole picture" we need to update our controllers.
		
		// 13.3 - Validating models in a controller
		
		// Refer to EventController.processCreateEventForm() in the coding-events project
		// @Valid annotation: 
		// When using the @ModelAttribute annotation to accept a form input (e.g. when creating an event), we can use the @Valid annotation
		// This will check the Model (in this case the Event class) for any constraints and check the provided input against it, if any fail, a
		// 400 (bad request) error page is returned with our "user-friendly" message.
		
		// This is kinda hideous though, lets look at the Errors class (another spring provided class)
		
		// 13.3.3.2 - Using the Errors object
		// The Errors class is part of the spring boot framework and found in the org.springframework.validation package.
		
		// The Errors class does the same validation for us and allows us to get more information. We can check to see if any constraint errors
		// occurred in the request by calling Errors hasErrors() method.
		
		// If hasErrors() returns true, we have some constraint issues and can handle them accordingly (passing an error message for example)
		
		// 13.4 - Thymeleaf Form Tools
		// Display validation errors for a field.
		// Thymeleaf provides model/form validation out of the box via the th:field tag.
		
		// 13.4.2.1 - Using th:field
		// Example: th:field="${event.description}" - This will map this form field to the Event classes description variable/field.
		// Refer to the create.html template in the coding-events project
		
		// In order to use the th:field tag, your model class (Event in this example) MUST have a no-arg/empty/default constructor 
		
		// 13.4.2.2 - Using th:errors
		// When doing form validation "client-side" using thymeleaf form validation, we need a way to display any constraint errors that may occur (for each field)
		// This is where the th:errors tag comes in handy

		// Example, if we wanted to have an area to display an error related to the Event classes description field (and that field only)
	    // <p class="error" th:errors="${event.description}"></p>

		// This will display the "user-friendly" message provided
	}
	
	private static void chapter14() {
		// 14.1 - Enums
		// Enums are "classes" that have a fixed set of values (like days of the week, etc)
		
		// Basic enum for "days of the week"
		/*
		public enum Day {
			   SUNDAY,
			   MONDAY,
			   TUESDAY,
			   WEDNESDAY,
			   THURSDAY,
			   FRIDAY,
			   SATURDAY
			}
		*/
		
		// Enums can be used in switch statements (remember those?)
		/*
		switch (dayNum) {
        	case Day.SUNDAY:
        		// do something
        		break;
        	case Day.MONDAY:
        		// Work
        		break;
		 */
		
		// Using enums is simple, you can declare a variable (in your model class for instance) of the enum type and set it to one of the fixed values, e.g. Day.MONDAY
		// Day workWeekStart = Day.MONDAY;
		
		// 14.1.3. - Adding Properties to Enums
		// You don't have to only have "fixed set of values" with enums, you can add additional properties (ids, other info, etc)
		// Refer to Day.java
		
		// 14.2 - Enums in Model classes
		// A great place to use enums (well one of them) is in your Model classes! 
		// Refer to EventType.java enum and Event.java class in the coding-events project
		
		// 14.2.2.4 - Passing enum values to the controller
		// Using the Enum method values() returns a collection of all possible enum values
		
		// 14.2.2.5 - Using enum values in select statement
		// Now that we've passed all of the possible enums in, we can use them in our thymeleaf template
		// Refer to create.html template in coding-events project
		
		// We combine an HTML select tag with a for/each loop to create a drop-down with all possible event types to select from!
		
		// 14.2.2.6. Use Enum Properties to Display Information
		// Example: <td th:text="${event.type.displayName}"</td>
		// This will call the getDisplayName on our type variable in our Event class (get all that :P)
		// Refer to index.html template in coding-events project to display our selected enums (for each event)
		
	}
}
