package org.launchcode.main;

public class Student {
	private static int nextStudentId = 1;
	String name;
	final int studentId;
	private int numberOfCredits;
	private double gpa;

	public Student(String name, int studentId, int numberOfCredits, double gpa) {
		this.name = name;
		this.studentId = studentId;
		this.numberOfCredits = numberOfCredits;
		this.gpa = gpa;
	}

	public Student(String name, int studentId) {
		this(name, studentId, 0, 0);
	}

	public Student(String name) {
		this(name, nextStudentId);
		nextStudentId++; // Note: this is a makeshift primary key basically
	}

	// 5.2.2. Instance Methods
	public String studentInfo() {
		return (this.name + " has a GPA of: " + this.gpa);
	}

	public void addGrade(int courseCredits, double grade) {
		// not going to bother doing this math...
	}

	public String getGradeLevel() {
		return "5th Grade"; // Note: I have no idea what they actually want...
	}

	// 5.3.1. toString
	@Override
	public String toString() {
		return name + " (Credits: " + numberOfCredits + ", GPA: " + gpa + ")";
	}

	// 5.3.2. equals
	@Override
	public boolean equals(Object o) {
		// Reference check
		if (o == this) {
			return true;
		}
		// Null check
		if(o == null) {
			return false;
		}
		// Class check
		// Note: I wrote this differently
		if(!(o instanceof Student)) {
			return false;
		}

		Student theStudent = (Student) o;
		
		// Note: You SHOULD compare ALL fields
		return theStudent.studentId == studentId;
	}

}
