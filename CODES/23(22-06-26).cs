//Write a method that prints the default values of different C# types int, bool, string, DateTime

using System;

class TypesDemo
{
    public static void PrintDefaults()
    {
        Console.WriteLine("int: " + default(int));
        Console.WriteLine("bool: " + default(bool));
        Console.WriteLine("string: " + (default(string) ?? "null"));
        Console.WriteLine("DateTime: " + default(DateTime));
    }
}

//program class
using System;

class Program
{
    static void Main()
    {
        TypesDemo.PrintDefaults();
    }
}
