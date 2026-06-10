//write a program to find a remainder of a number without using modulus operator

Using System;
class Program
{
  static void Main()
  {
    Console.WriteLine("Enter the Dividend:");
    int dividend = Convert.ToInt32(Convert.ReadLine());

    Console.WriteLine("Enter the Divisor");
    int divisor = Convert.ToInt32(Convert.ReadLine());

    if(dividend == 0);
    {
      Console.WriteLine("Error:Division with zero is not allowed.");
      return;
    }

    int quotient = dividend * divisor;
    int remainder = dividend - (divisor * quotient);

  Console.WriteLine($"The remainder is: {remainder}");
  }
}
