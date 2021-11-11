# This example creates a table called johnson_wedding with an integer, 3 strings, and a boolean
CREATE TABLE johnson_wedding (
			   guest_id INT,
			   last_name VARCHAR(255),
			   first_name VARCHAR(255),
			   attending BOOL,
			   diet VARCHAR(255)
			);
COMMIT;

# Not used very often, but you can create a new table with data from another table
CREATE TABLE johnson_vow_renewal
			AS SELECT guest_id, last_name, first_name, attending, diet
		   	FROM johnson_wedding
		   	WHERE attending = 1;

COMMIT;

# This will insert her into the wedding!
INSERT INTO johnson_wedding
			VALUES (185, "Johnson", "Eliza", 1, "Vegan", true);

# The following example will insert into the table johnson_vow_renewal with the values provided
INSERT INTO johnson_vow_renewal
			VALUES (185, "Johnson", "Eliza", 1, "Vegan");

COMMIT;

# You can also specify which columns to INSERT INTO with the following query
INSERT INTO johnson_vow_renewal (guest_id, last_name, first_name)
			VALUES (186, "Johnson", "Felicity");

COMMIT;

# If you want to add more data types to a column (similar to adding a new variable to an object class) we use the ALTER TABLE query
ALTER TABLE johnson_wedding
			ADD can_drink BOOL;
            
COMMIT;

# We SELECT columns FROM a specific table WHERE some conditions are true
SELECT last_name, first_name
			FROM johnson_wedding
			WHERE (attending = 1) AND (diet = "vegetarian");

# If you want to select ALL fields from a table, you can use the *
SELECT * FROM johnson_wedding;

# When you want to change existing data in a database, we use the UPDATE statement
# Note: In order to do this in MySQLWorkbench, you may need to disable safe mode!
UPDATE johnson_vow_renewal
			SET diet="vegetarian", first_name="Elizabeth"
			WHERE guest_id=185;
            
COMMIT;

# We DELETE FROM a specific table WHERE some conditions are true
DELETE FROM johnson_vow_renewal WHERE guest_id=107;

COMMIT;



