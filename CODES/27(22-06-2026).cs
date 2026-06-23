//Find the age from entered date of birth

using System;

class AgeCalculator
{
    public static void FindAge(DateTime dob)
    {
        DateTime today = DateTime.Today;

        int age = today.Year - dob.Year;

        if (dob.Date > today.AddYears(-age))
            age--;

        Console.WriteLine("Age: " + age);
    }
}

//program class

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Date of Birth (dd/MM/yyyy): ");
        DateTime dob = DateTime.Parse(Console.ReadLine());

        AgeCalculator.FindAge(dob);
    }
}
