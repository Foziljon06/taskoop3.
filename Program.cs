using System;
using System.Collections.Generic;
using Models; // Import Models namespace to access Student and Grade

namespace Models
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the sample list of students from the Student class
            List<Student> students = Student.GetSampleStudents();

            // Ask for user input to filter students based on their grade
            Console.WriteLine("Bahoni kiriting (5 - Excellent, 4 - Good, 3 - Satisfactory, 2 - Poor):");
            string input = Console.ReadLine();
            bool isValidGrade = Enum.TryParse(input, out Grade selectedGrade);

            // Check if the input is valid
            if (!isValidGrade || !Enum.IsDefined(typeof(Grade), selectedGrade))
            {
                Console.WriteLine("Noto'g'ri baho kiritildi!");
                return;
            }

            // Filter students using a for loop
            List<Student> filteredStudents = new List<Student>();
            foreach (var student in students)
            {
                if (student.Grade == selectedGrade)
                {
                    filteredStudents.Add(student);
                }
            }

            // Display the filtered list
            if (filteredStudents.Count > 0)
            {
                Console.WriteLine($"\nBahosi {selectedGrade} bo'lgan o'quvchilar:");
                foreach (var student in filteredStudents)
                {
                    Console.WriteLine($"ID: {student.Id}, Ism: {student.FirstName}, Familya: {student.LastName}, Sinf: {student.Class}");
                }
            }
            else
            {
                Console.WriteLine($"\nBahosi {selectedGrade} bo'lgan o'quvchilar topilmadi.");
            }
        }
    }
}
