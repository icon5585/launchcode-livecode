using System;
namespace Class_2._3
{
    public class Student
    {
        // You should declare everything PRIVATE unless you have a very good reason not to
        // These are the "properties" of the class
        private string name;
        private int studentId;
        private int numberOfCredits;
        private double gpa;

        // 4.4.1 Overloading Constructors
        // NOTE: Take note of the use of the this keyword. This allows us to have variables with the same
        // names as the properties of the class in the constructor method signature
        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {
            this.name = name;
            this.studentId = studentId;
            this.numberOfCredits = numberOfCredits;
            this.gpa = gpa;
        }

        // This is chaining constructors, the this() calls the constructor above
        public Student(string name, int studentId) : this(name, studentId, 0, 0)
        {}

        // Need this defined if we want a no-arg constructor since we provided our own above
        public Student() : this("", 0, 0, 0)
        {}

        // Modifiers for the string name
        // You can access this using the dot notation
        public string Name
        {
            // GETTER
            get { return name; }
            // SETTER
            set { name = value; }
        }

        // Shorthand for getter/setters
        public int StudentId { get; set; }
    }


}
