using System;
using System.Collections.Generic;
using System.Text;

namespace proj1
{
    internal class ConditionalExample
    {
        //CLASS03--CONDITIONAL STATEMENTS-MAAM GIVEN CODE


        /*public static void sarah1()
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("The largest number is: " + num1);
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("The largest number is: " + num2);
            }
            else
            {
                Console.WriteLine("The largest number is: " + num3);
            }

        }*/
        //CLASS03--IF ELSE STATEMENT-ASSIGNMENT QUESTION
        //Accept character from user and check whether it is a letter, digit or special character.


        /*public void check()
        {
            Console.Write("Enter a character:");
            char c = Convert.ToChar(Console.ReadLine());

            if (char.IsLetter(c))
            {
                Console.WriteLine("The character is a letter.");

            }
            else if (char.IsDigit(c))
            {
                Console.WriteLine("The character is a digit.");
            }

            else
            {
                Console.WriteLine("The character is a special character.");
            }
        }*/

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
        
        
    }
}






