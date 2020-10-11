using System;
namespace Class_2._5
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        private readonly int studentId;
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int sId, int numberOfCredits, double gpa)
        {
            Name = name;
            studentId = sId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int sId)
        {
            Name = name;
            studentId = sId;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public Student(string name)
        {
            Name = name;
            studentId = nextStudentId;
            nextStudentId++;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public string StudentInfo()
        {
            return (Name + " has a GPA of: " + Gpa);
        }

        public void AddGrade(int courseCredits, double grade)
        {
            // TODO: Finish in exercise!
        }

        public string GetGradeLevel()
        {
            // TODO: Finish in exercise!
            return "";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, studentId, NumberOfCredits, Gpa);
        }

        // 5.3.1 ToString override example
        public override string ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }

        // 5.3.2 Equals override example
        public override Boolean Equals(object toBeCompared)
        {
            // 1) Check if the object to be compared is itself
            // Reference check: If the two objects are the same, return true right away.
            if (toBeCompared == this)
            {
                return true;
            }

            // 2) Make sure the object to be compare is not NULL
            // Null check: If the argument is null, return false.
            if (toBeCompared == null) {
                return false;
            }


            // 3) Second thing to check is if the classes are the same, if not, they can't be equals
            // Class check: Compare the classes of the two objects to ensure a safe cast. Return false if the classes are different.
            if (toBeCompared.GetType() != GetType())
            {
                return false;
            }

            // 4) Cast the OBJECT to a STUDENT and store it in s
            // Cast: Convert the argument to the type of our class, so getters and other methods can be called.
            // Custom comparison: Use custom logic to determine whether or not the two objects should be considered equal. This will usually be a comparison of class properties.
            if (toBeCompared is Student s)
            {
                return s.studentId == studentId;
            }

            // Lastly, if they're not equal, return false
            return false;
        }

    }
}
