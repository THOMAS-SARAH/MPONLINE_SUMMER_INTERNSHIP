using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("Enter the sentence");
    string input = Console.ReadLine();

    string reversed = "";

    for(int i = input.Length -1; i++)
    {
      reversed += input[i];
    }

    Console.WriteLine("The reversed sentence is:" + reversed};
  }
    
}
