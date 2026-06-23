//Input password and Find the Password strength based on following rules
//1. Length should be 8
//2. Must have one capital letter
//3. One digit is compulsory

using System;

class PasswordStrength
{
    public static void CheckPassword(string password)
    {
        bool hasUpper = false;
        bool hasDigit = false;

        foreach (char ch in password)
        {
            if (char.IsUpper(ch))
                hasUpper = true;

            if (char.IsDigit(ch))
                hasDigit = true;
        }

        if (password.Length >= 8 && hasUpper && hasDigit)
            Console.WriteLine("Strong Password");
        else
            Console.WriteLine("Weak Password");
    }
}

//program class

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Password: ");
        string password = Console.ReadLine();

        PasswordStrength.CheckPassword(password);
    }
}
