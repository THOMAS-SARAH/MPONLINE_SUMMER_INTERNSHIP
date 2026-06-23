/*Write a C# program that prits numbers from 1 to 50, but with these rules:

If the number is divisible by 3, print "3".
 If the number is divisible by 5, print "5".
 If the number is divisible by both 3 and 5, print "3-5".
 If the number is prime, print "Prime".
 Otherwise, just print the number itself.
 WAP to print groups of anagrams from a given list*/

using System;

class NumberRules
{
    static bool IsPrime(int n)
    {
        if (n < 2) return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0)
                return false;

        return true;
    }

    public static void PrintNumbers()
    {
        for (int i = 1; i <= 50; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("3-5");
            else if (i % 3 == 0)
                Console.WriteLine("3");
            else if (i % 5 == 0)
                Console.WriteLine("5");
            else if (IsPrime(i))
                Console.WriteLine("Prime");
            else
                Console.WriteLine(i);
        }
    }
}

//program class

using System;

class Program
{
    static void Main()
    {
        NumberRules.PrintNumbers();
    }
}
