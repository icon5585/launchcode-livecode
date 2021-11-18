# Create a courses table
CREATE TABLE courses (
			   course_id INTEGER PRIMARY KEY AUTO_INCREMENT,
			   course_title VARCHAR(40),
			   course_minutes INTEGER,
			   course_description TEXT,
			   credits INTEGER
			);

COMMIT;

# Create a teachers table with an FK constraint on the courses table
CREATE TABLE teachers (
			   teacher_id INTEGER PRIMARY KEY AUTO_INCREMENT,
			   first_name VARCHAR(40),
			   last_name VARCHAR(40),
			   email VARCHAR(80),
			   hire_date DATE,
			   course_id INTEGER,
			   FOREIGN KEY (course_id) REFERENCES courses(course_id)
			);

COMMIT;

# Add a course into the courses table (this is required to be done first due to the FK constraint
INSERT INTO COURSES (course_title, course_minutes, course_description, credits) VALUES ("LC101", 180, "LC 101 for Philadelphia!", 1);
COMMIT;

# Add a teacher into the teachers table that teaches the course added above
INSERT INTO TEACHERS (first_name, last_name, course_id) VALUES ("Hank", "DeDona", 1);
COMMIT;

# Verify that the teacher and course are added and related
SELECT t.first_name, t.last_name, c.course_title, c.course_description FROM TEACHERS t INNER JOIN COURSES c ON t.course_id = c.course_id;

# What happens if I try to insert a new teacher and put an invalid course ID?
INSERT INTO TEACHERS (first_name, last_name, course_id) VALUES ("Jim", "Jenkins", 1337);
COMMIT;



