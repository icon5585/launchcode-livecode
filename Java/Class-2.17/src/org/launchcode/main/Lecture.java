package org.launchcode.main;

public class Lecture {

	/**
	 * Class 2.17 - Chapter 18.1-18.3 - Relationships in ORM Part 1
	 * 
	 * Hank DeDona
	 * 
	 * @param args arguments passed into app at runtime
	 */
	public static void main(String[] args) {
		// 18.1 - Types of relationships
		// Review relationships here:
		// https://education.launchcode.org/java-web-development/chapters/orm-relationships/types-of-relationships.html
		
		// One-to-one
		// One-to-many/Many-to-one
		// Many-to-many
		
		// 18.2 - Creating a many-to-one relationship
		// @ManyToOne annotation
		// Refer to Event.java in coding-events project
		
		// 18.2.1 - AbstractEntity
		// Refer to the AbstractEntity.java class in the coding-events project
		
		// 18.2.4.1. Replacing EventType With EventCategory
		// Refer to the Event.java class in the coding-events project
		
		// 18.3 - Creating a one-to-many relationship
		// @OneToMany annotation
		
		// 18.3.2. Setting Up the Relationship
		// Refer to the EventCategory.java class in the coding-events project
		
		// What does this do for us? It creates foreign key relationships
		// Refer to the event DB table, it's added a new field "event_category_id" which references the event_category ID field 
	}
}
