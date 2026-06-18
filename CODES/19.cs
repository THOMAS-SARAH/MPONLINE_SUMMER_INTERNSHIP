-- Create a list of employees with Name and Salary. Use a lambda expression to filter employees earning more than 10,000.

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var employees = new List<(string Name, int Salary)>
        {
            ("Rahul", 12000),
            ("Priya", 9000),
            ("Aman", 15000),
            ("Neha", 8000)
        };

        var highSalary = employees.Where(e => e.Salary > 10000);

        foreach (var e in highSalary)
            Console.WriteLine($"{e.Name} {e.Salary}");
    }
}

-- OUTPUT
Rahul 12000
Aman 15000
