package org.launchcode.main;

public class Lecture {

	/**
	 * Class 2.14 - 2/24/2020 - Chapter 15 - Databases and SQL - Hank DeDona
	 * 
	 * @param args arguments passed into app at runtime
	 */
	public static void main(String[] args) {
		// 15.1 - What is SQL?
		// Structured Query Language - the language of relational databases!
		
		// Relational databases store data in tables (with columns and rows)
		// This is not how we store data in our code, we have objects!
		
		// For this class we'll be using MySQL (a commonly used, open source and free DBMS)
		
		// Data Types
		
		// 15.1.1.1. Numbers
		// There are multiple number types in MySQL including INT, BIGINT, DOUBLE, etc.
		
		// 15.1.1.2. Strings
		// Strings in MySQL are called VARCHAR, you can also specify a max size via VARCHAR(250)
		
		// 15.1.1.3. Boolean
		// Boolean values in MySQL are called BOOL - they store true or false values
		
		// 15.2 - SQL Queries
		// How we get data into and out of databases are through SQL queries.
		// CRUD - Create, read, update and delete
		
		// 15.2.1.1 - Create a table
		// This example creates a table called johnson_wedding with an integer, 3 strings, and a boolean
		/*
		 * CREATE TABLE johnson_wedding (
			   guest_id INT,
			   last_name VARCHAR(255),
			   first_name VARCHAR(255),
			   attending BOOL,
			   diet VARCHAR(255)
			);
		 */
		
		// 15.2.1.1.2. Creating a Table from Another Table
		// Not used very often, but you can create a new table with data from another table
		/*
		 CREATE TABLE johnson_vow_renewal
			AS SELECT guest_id, last_name, first_name, attending, diet
		   	FROM johnson_wedding
		   	WHERE attending = 1;
		 */

		// 15.2.1.2. Adding a Row
		// How to create a new entry in your database
		// Using the INSERT INTO query
		
		// The following example will insert into the table johnson_vow_renewal with the values provided
		/*
		 * INSERT INTO johnson_vow_renewal
			VALUES (185, "Johnson", "Eliza", 1, "Vegan");
		 */

		// You can also specify which columns to INSERT INTO with the following query
		/*
		 * INSERT INTO johnson_vow_renewal (guest_id, last_name, first_name)
			VALUES (186, "Johnson", "Felicity");
		 */
		
		// 15.2.1.3. Adding a column
		// If you want to add more data types to a column (similar to adding a new variable to an object class) we use the ALTER TABLE query
		
		/*
		 * ALTER TABLE johnson_wedding
			ADD can_drink BOOL;	
		 */
		
		// 15.2.2. Read
		// If you want to get data from a specific table, we use the SELECT statement
		// Note: This is mostly what you'll be doing
		
		// We SELECT columns FROM a specific table WHERE some conditions are true
		/*
		 * SELECT column_name_1, column_name_2, ...
			FROM table_name
			WHERE some conditional is true
		 */
		
		// Note: You can also use AND/OR in your conditional WHERE clause 
		/*
		 * SELECT last_name, first_name
			FROM johnson_wedding
			WHERE (attending = 1) AND (diet = "vegetarian");
		 */
		
		// If you want to select ALL fields from a table, you can use the *
		/*
		 * SELECT *
			FROM johnson_wedding;
		 */
		
		//15.2.3. Update
		// When you want to change existing data in a database, we use the UPDATE statement 
		
		// We UPDATE a specific table and SET values WHERE some conditions are true
		// Note: You can set multiple column values at once
		// Note 2: In order to do this in MySQLWorkbench, you may need to disable safe mode!
		/*
		 * UPDATE johnson_vow_renewal
			SET diet="vegetarian", first_name="Elizabeth"
			WHERE guest_id=185;
		 */
		
		// 15.2.4. Delete
		// When you want to delete data from a database, we use the DELETE statement

		// We DELETE FROM a specific table WHERE some conditions are true
		
		/*
		 * DELETE FROM johnson_vow_renewal WHERE guest_id=107;
		 */
		
		// 15.3 - Joins
		// Joins are used to combine the data from 2 or more tables
		// 4 Different types of joins
		// 1) Inner Join
		// 2) Left Outer Join 
		// 3) Right Outer Join 
		// 4) Full Outer Join 
		
		// Usually when we join we do it with SELECT statements
		
		// We SELECT columns FROM a table1 then JOIN table2 ON table1.val = table2.val (where the values are foreign keys)
		/*
		 * SELECT column_name_1, column_name_2, ....
			FROM table_a
			INNER JOIN table_b ON table_a.column_name_1 = table_b.column_name_1;
		 */
		
		// Inner Join - Where values are on BOTH tables
		// Left Outer Join - Where the values are on the LEFT and BOTH tables
		// Right Outer Join - Where the values are on the RIGHT and BOTH tables
		// Full Outer Join - Where the values are on ALL tables (inclusive) - Don't use these too often
		
	}
}
