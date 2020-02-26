package org.launchcode.main;

public class Lecture {

	/**
	 * Class 2.15 - 2/26/2020 - Chapter 16 - SQL Part Deux - Hank DeDona
	 * 
	 * @param args arguments passed into app at runtime
	 */
	public static void main(String[] args) {
		// 16.1 Table Relationships
		
		// 16.1.2 - One to many relationships
		// Each entry in one table relates to many rows in a different table.
		
		// 16.1.3 - Table Keys
		// Each and every table MUST have a primary key that is unique
		
		// In order to have a foreign key relationship, you must have a column that represents the primary key of another table. 
		
		// 16.1.3.1 - Adding a primary key
		// column_name INTEGER PRIMARY KEY AUTO_INCREMENT
		// AUTO_INCREMENT - This allows MySQL to keep track of the primary key and assign the values for us.
		
		// E.g. - A courses table
		/*
		 * CREATE TABLE courses (
			   course_id INTEGER PRIMARY KEY AUTO_INCREMENT,
			   course_title VARCHAR(40),
			   course_minutes INTEGER,
			   course_description TEXT,
			   credits INTEGER
			);
		 */
		
		// 16.1.3.2 - Adding a foreign key
		// column_name INTEGER, FOREIGN KEY (column_name) REFERENCES other_table(primary_key_column)
		
		// E.g. - A teachers table
		/*
		 * CREATE TABLE teachers (
			   teacher_id INTEGER PRIMARY KEY AUTO_INCREMENT,
			   first_name VARCHAR(40),
			   last_name VARCHAR(40),
			   email VARCHAR(80),
			   hire_date DATE,
			   course_id INTEGER,
			   FOREIGN KEY (course_id) REFERENCES courses(course_id)
			);
		 */
		
		// One-to-one - Similar to one-to-many, but where only 1 relationship between the tables is allowed.
		
		// Many-to-many - Many relationships between both tables, requires a 3rd table that have two one-to-many relationships between them.
		
		// 16.2 - Has you walking through creating tables/relationships using MySQL Workbench
		
		// 16.3 - Complex Queries
		
		// Inner Join Refresher
		// SELECT * FROM movies m INNER JOIN directors d ON m.director_id = d.director_id;
		// This will get all data where it overlaps on BOTH tables (movies and diretors in this example)
		
		// Left/Right Outer Join Refresher
		// This will get the data where it overlaps OR exists in the left or right table.
		
		// 16.3.1.3 - Multiple Joins
		// You can join together two select statements using the UNION keyword
		// Note: Run these separately, then UNION them.
		/*
		 *  SELECT writing_supply.supply_id, utensil_type, drawer_id, quantity FROM writing_supply
			LEFT JOIN pencil_drawer ON writing_supply.supply_id = pencil_drawer.supply_id
			WHERE refill = true
			
			UNION
			
			SELECT writing_supply.supply_id, utensil_type, drawer_id, quantity FROM writing_supply
			RIGHT JOIN pen_drawer ON writing_supply.supply_id = pen_drawer.supply_id
			WHERE refill = true
			ORDER BY supply_id;
		 */
		
		// 16.3.1.2 - Subqueries
		// Subqueries are commonly used in WHERE clauses of select statements to get a very specific subset of data.
		// They can also be used in INSERT, UPDATE and DELETE queries as well.
		
		// E.g. - Select statement within the where block using the IN keyword
		// The IN keyword is used to say WHERE some data is IN this possible subset of data
		/* 
		 * SELECT drawer_id, color FROM pen_drawer
				WHERE supply_id IN (SELECT supply_id FROM writing_supply WHERE utensil_type = "Pen");
		 */
		
	}
}
