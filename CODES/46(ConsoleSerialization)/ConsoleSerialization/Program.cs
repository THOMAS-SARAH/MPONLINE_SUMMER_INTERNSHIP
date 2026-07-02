using System;
using System.Text.Json;

namespace ConsoleSerialization
{
    internal class Program
    {
        static string json;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            StudentSerializing();
            StudentDeSerializing();
        }

        static void StudentSerializing()
        {
            Student student = new Student
            {
                Name = "Smita",
                Age = 23,
                StudentId = 43
            };

            Console.WriteLine(student.GetHashCode());

            json = JsonSerializer.Serialize(student);

            Console.WriteLine(json);
        }

        static void StudentDeSerializing()
        {
            Student student = JsonSerializer.Deserialize<Student>(json);

            Console.WriteLine(student.Name);
            Console.WriteLine(student.GetHashCode());
        }
    }
}
