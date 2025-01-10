using System;
using System.Collections.Generic;

namespace Models
{
    // Enum definition for Grades
    public enum Grade
    {
        Excellent = 5,
        Good = 4,
        Satisfactory = 3,
        Poor = 2
    }

    // Student class definition
    public class Student
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Class { get; set; }
        public Grade Grade { get; set; }

        public Student(string firstName, string lastName, int classNumber, Grade grade)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Class = classNumber;
            Grade = grade;
        }

        // Static method to generate a sample list of students
        public static List<Student> GetSampleStudents()
        {
            return new List<Student>
            {
                new Student("Ali", "Valiyev", 10, Grade.Excellent),
                new Student("Sara", "Karimova", 11, Grade.Good),
                new Student("Timur", "Ismoilov", 10, Grade.Satisfactory),
                new Student("Laylo", "Akramova", 9, Grade.Poor),
                new Student("Olim", "Rasulov", 11, Grade.Excellent)
            };
        }
    }
}
