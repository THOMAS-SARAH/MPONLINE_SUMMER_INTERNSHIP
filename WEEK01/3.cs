using System;
using System.Collections.Generic;
using System.Text;

namespace proj1
{
     //ASSIGNMENT QUESTION - USE SWITCH CSE TO SHOW ARITHMATIC OPERATORS and perform repeation based on user's choice

        public static void func()
        {
            bool continueProgram = true;
            while (continueProgram)
            {
                Console.Write("\nHow many operations would you like to perform? ");
                if (int.TryParse(Console.ReadLine(), out int repetitions))
                {
                    for (int i = 1; i <= repetitions; i++)
                    {
                        Console.WriteLine($"\n--- Operation {i} ---");
                        Console.WriteLine("1. Addition (+), 2. Subtraction (-), 3. Multiplication (*), 4. Division (/)");
                        Console.Write("Choose (1-4): ");
                        string choice = Console.ReadLine();
                        Console.Write("Enter two numbers: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        double num2 = Convert.ToDouble(Console.ReadLine());

                        switch (choice)
                        {
                            case "1": Console.WriteLine($"Result: {num1 + num2}"); break;
                            case "2": Console.WriteLine($"Result: {num1 - num2}"); break;
                            case "3": Console.WriteLine($"Result: {num1 * num2}"); break;
                            case "4": Console.WriteLine(num2 != 0 ? $"Result: {num1 / num2}" : "Error: Div by 0"); break;
                            default: Console.WriteLine("Invalid choice."); break;
                        }
                    }
                }
                Console.Write("\nStart a new batch? (y/n): ");
                continueProgram = Console.ReadLine().ToLower() == "y";
            }
}

using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            ConditionalExample.func();
        }
    }
    
    
    
    
        
        
    
