package org.launchcode.main;

// 4.3.1 Encapsulation
public class Student {

	// 4.3.2.1 Fields
	// Should always make private unless you have a very
	// good reason not to!
	private String name;
	private int studentId;
	private int numberOfCredits = 0;
	private double gpa = 0.0;

	// Default constructor (boring)
	// Not required!
	public Student() {
	}

	// 4.4.1 Overloading constructors
	// You can provide multiple constructors (i.e. overloading) with different
	// method "signatures", what this means is that they have different parameters
	// in their constructors.
	// Look below, the first constructor takes in 4 variables while the bottom one
	// only takes in 2.
	public Student(String name, int studentId, int numberOfCredits, double gpa) {
		this.name = name;
		this.studentId = studentId;
		this.numberOfCredits = numberOfCredits;
		this.gpa = gpa;
	}

	// Note the use of the THIS keyword again.
	// this() means calling a constructor, it is very common for
	// overloading constructors to call other constructors like this.
	public Student(String name, int studentId) {
		this(name, studentId, 0, 0);
	}
	
	// 4.5.2. Instance Methods
	public String studentInfo() {
        return (this.name + " has a GPA of: " + this.gpa);
    }

	// 4.3.2.2 Getters and setters
	// Note: I don't use the aName or aStudentId... I've
	// yet to ever see this in industry.
	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public int getStudentId() {
		return studentId;
	}

	public void setStudentId(int studentId) {
		this.studentId = studentId;
	}

	public int getNumberOfCredits() {
		return numberOfCredits;
	}

	public void setNumberOfCredits(int numberOfCredits) {
		this.numberOfCredits = numberOfCredits;
	}

	public double getGpa() {
		return gpa;
	}

	public void setGpa(double gpa) {
		this.gpa = gpa;
	}

}
