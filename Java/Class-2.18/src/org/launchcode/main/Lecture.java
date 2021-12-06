package org.launchcode.main;

public class Lecture {

	/**
	 * Class 2.18 - Chapter 18.4 & 18.5 - Relationships in ORM Part 2
	 * 
	 * Hank DeDona
	 * 
	 * @param args arguments passed into app at runtime
	 */
	public static void main(String[] args) {
		// 18.4 - One-to-one relationships
		// @OneToOne annotation
		// Refer to new EventDetails.java, Event.java and EventController.java classes in coding-events project
		
		// 18.4.2.4 - Cascading ORM Operations
		// What does it mean to cascade? cascade-on-create, cascade-on-update and cascade-on-delete
		
		// 18.5 - Many-to-many relationships
		// Many-to-many relationships are actually two one-to-many relationships with a relationship table between the two tables
		// Refer to Tag.java and Event.java in coding-events project
	
		// The class to manage that many-to-many relationship is referred to as a DTO (Data Transfer Object)
		// It's sole purpose is to manage the relationship by having variables of both classes in one class
		// Refer to EventTagDTO.java in coding-events project
		
		// 18.5.6.3 - Join Tables
		// The "join table" is the relationship table between two one-to-many relationships in order to enable a many-to-many relationship
		// The join table will have two values, both primary keys of the respective other tables in order to create the relationship
		
		// Refer to diagrams on https://education.launchcode.org/java-web-development/chapters/orm-relationships/many-to-many.html
	}
	
}
