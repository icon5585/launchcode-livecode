package org.launchcode.class26;

public class Lecture {
	
	/**
	 * Class 2.16 - Chapter 17 - Object-Relational Mapping (ORM)
	 * Hank DeDona
	 * 
	 * @param args arguments passed into app at runtime
	 */
	public static void main(String[] args) {
		// 17.1 - ORM
		section17_1();
		
		// 17.2 - Accessing Data
		section17_2();
		
		// 17.3 - Repositories
		section17_3();
	}
	
	private static void section17_1() {
		// Quick recap
		// We create classes to represent data as objects in Java
		// We store data in databases in tables with relationships between them
		// These paradigms don't really work seamlessly between each other...
		
		// This is where ORMs come into play!
		// ORM is a technique for converting data between Java objects and relational databases.
		
		// This allows you to use and store Java objects as they already exist without having to worry
		// about translating them into SQL to store in in a table (or multiple tables).
		
		// E.g. a ContactInfo object
		// Java
		ContactInfo frank = new ContactInfo("Frank", "frank@email.com");
		
		// SQL
		// INSERT INTO contactinfo (id,name,email) VALUES (3,"Frank","frank@email.com");
		
		// 17.1.1 ORM in Spring
		// In order to use ORM in spring, we'll need to import a couple of dependencies including the JPA and mysql connector
		
		// implementation 'org.springframework.boot:spring-boot-starter-data-jpa' (JPA - Java Persistence API)
		// implementation 'mysql:mysql-connector-java'
		
		// In order to connect your Spring application to the MySQL database, we require a bit of configuration in
		// your applications.properties file. 
		// Refer to applications.properties in this project.
	}
	
	private static void section17_2() {
		// In order to create a link between your application and the MySQL database, we need to create a few things
		
		// 1) A class to represent the object that has the data that will be stored in the DB
		// Refer to ContactInfo.java in this project
		
		// 2) A repository to contain the CRUD (create, read, update, and delete) methods for the entity (ContactInfo.java)
		// Refer to ContactInfoRepository.java in this project

		// 3) And something to create the objects (ContactInfo) and use the repository. This is *usually* a controller.
	}
	
	private static void section17_3() {
		// As mentioned earlier, repositories provide the CRUD methods for our objects that are to be persisted.
		// E.g. Our ContactInfoRepository class
		
		// Repositories that extend the CrudRepository interface provide some handy methods for us to work with our persisted objects.
		// delete(T entity),   - DELETE
		// deleteById(ID id),  - DELETE
		// findAll()           - READ
		// findById(ID id)     - READ
		// save(S entity)	   - CREATE/UPDATE
		
		// Refer to the ContactInfoController.java class in this project 
		// There is a hacked together controller GET mapping to the root (index) with a crudOperation query param
	}
}
