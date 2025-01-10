using System;
using System.Collections.Generic;
using Models; // Import Models namespace to access Student and Grade


     //                             OOP bo'limi uchun 3-amaliy vazifa
     //                                   Task 1




namespace Models
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = Student.GetSampleStudents();

            Console.WriteLine("Bahoni kiriting (5 - Excellent, 4 - Good, 3 - Satisfactory, 2 - Poor):");
            string input = Console.ReadLine();
            bool isValidGrade = Enum.TryParse(input, out Grade selectedGrade);

            if (!isValidGrade || !Enum.IsDefined(typeof(Grade), selectedGrade))
            {
                Console.WriteLine("Noto'g'ri baho kiritildi!");
                return;
            }

            List<Student> filteredStudents = new List<Student>();
            foreach (var student in students)
            {
                if (student.Grade == selectedGrade)
                {
                    filteredStudents.Add(student);
                }
            }

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



     //                             OOP bo'limi uchun 3-amaliy vazifa
     //                                   Task 2


namespace CarPriceFilter
{
    class Program
    {
        public class Car
        {
            public string Model { get; set; }
            public string Brand { get; set; }
            public decimal Price { get; set; }

            public Car(string model, string brand, decimal price)
            {
                Model = model;
                Brand = brand;
                Price = price;
            }
        }

        static void Main(string[] args)
        {
            // Avtomobillar ma'lumotlari (List)
            List<Car> cars = new List<Car>
            {
                new Car("Model X", "Tesla", 80000),
                new Car("Civic", "Honda", 25000),
                new Car("Corolla", "Toyota", 20000),
                new Car("S5", "Audi", 45000),
                new Car("F-150", "Ford", 35000),
                new Car("Mustang", "Ford", 55000),
                new Car("Kona", "Hyundai", 25000),
                new Car("A4", "Audi", 40000)
            };

           
            Console.WriteLine("Iltimos, minimal narxni kiriting:");
            decimal minPrice = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Iltimos, maksimal narxni kiriting:");
            decimal maxPrice = decimal.Parse(Console.ReadLine());

            
            Console.WriteLine($"\nNarxi {minPrice} va {maxPrice} orasida bo'lgan avtomobillar:");
            foreach (var car in cars)
            {
                if (car.Price >= minPrice && car.Price <= maxPrice)
                {
                    Console.WriteLine($"Model: {car.Model}, Brend: {car.Brand}, Narx: {car.Price} USD");
                }
            }
        }
    }
}



     //                             OOP bo'limi uchun 3-amaliy vazifa
     //                                   Task 3




namespace BoxingCategorization
{
    class Program
    {
        public class Boxer
        {
            public int Id { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public int Age { get; set; }
            public decimal Weight { get; set; }

            public Boxer(int id, string lastName, string firstName, int age, decimal weight)
            {
                Id = id;
                LastName = lastName;
                FirstName = firstName;
                Age = age;
                Weight = weight;
            }
        }

        static void Main(string[] args)
        {
            // Bokschilar ro'yxati (List)
            List<Boxer> boxers = new List<Boxer>
            {
                new Boxer(1, "Aliyev", "Olim", 25, 47),
                new Boxer(2, "Karimov", "Sarvar", 28, 55),
                new Boxer(3, "Ismailov", "Timur", 30, 80),
                new Boxer(4, "Akramov", "Laylo", 22, 92),
                new Boxer(5, "Rasulov", "Olim", 26, 100),
                new Boxer(6, "Valiyev", "Diyorbek", 24, 72),
                new Boxer(7, "Xamidov", "Sherzod", 29, 65)
            };

            // Bokschilarni vazniga qarab saralash
            List<Boxer> lightWeightBoxers = new List<Boxer>();  // Yengil vaznli
            List<Boxer> middleWeightBoxers = new List<Boxer>(); // O'rta vaznli
            List<Boxer> heavyWeightBoxers = new List<Boxer>();  // Og'ir vaznli

            foreach (var boxer in boxers)
            {
                if (boxer.Weight <= 50)
                    lightWeightBoxers.Add(boxer);
                else if (boxer.Weight > 50 && boxer.Weight <= 76)
                    middleWeightBoxers.Add(boxer);
                else if (boxer.Weight >= 90)
                    heavyWeightBoxers.Add(boxer);
            }

            // Natijalarni chiqarish
            Console.WriteLine("Yengil vaznli bokschilar (50 kg gacha):");
            foreach (var boxer in lightWeightBoxers)
            {
                Console.WriteLine($"ID: {boxer.Id}, Familiya: {boxer.LastName}, Ism: {boxer.FirstName}, Yoshi: {boxer.Age}, Vazni: {boxer.Weight} kg");
            }

            Console.WriteLine("\nO'rta vaznli bokschilar (50 dan 76 kg gacha):");
            foreach (var boxer in middleWeightBoxers)
            {
                Console.WriteLine($"ID: {boxer.Id}, Familiya: {boxer.LastName}, Ism: {boxer.FirstName}, Yoshi: {boxer.Age}, Vazni: {boxer.Weight} kg");
            }

            Console.WriteLine("\nOg'ir vaznli bokschilar (90 kg va undan og'irlar):");
            foreach (var boxer in heavyWeightBoxers)
            {
                Console.WriteLine($"ID: {boxer.Id}, Familiya: {boxer.LastName}, Ism: {boxer.FirstName}, Yoshi: {boxer.Age}, Vazni: {boxer.Weight} kg");
            }
        }
    }
}

