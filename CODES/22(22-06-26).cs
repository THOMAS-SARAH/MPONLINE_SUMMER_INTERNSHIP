//Make a basic number guessing challenge against the computer

using System;

class NumberGuessing
{
    public static void Play()
    {
        Random random = new Random();
        int number = random.Next(1, 101);
        int guess;

        Console.WriteLine("Guess a number between 1 and 100");

        do
        {
            guess = int.Parse(Console.ReadLine());

            if (guess < number)
                Console.WriteLine("Too low!");
            else if (guess > number)
                Console.WriteLine("Too high!");
            else
                Console.WriteLine("Correct!");
        }
        while (guess != number);
    }
}

// program class

using System;

class Program
{
    static void Main()
    {
        NumberGuessing.Play();
    }
}

