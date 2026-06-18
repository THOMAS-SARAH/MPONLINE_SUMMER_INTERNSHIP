using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the size of the arrays: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] array1 = new int[size];
        int[] array2 = new int[size];
        int[] sumArray = new int[size];

        // Input for First Array
        Console.WriteLine($"Enter {size} elements for the first array:");
        for (int i = 0; i < size; i++)
        {
            array1[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Input for Second Array
        Console.WriteLine($"Enter {size} elements for the second array:");
        for (int i = 0; i < size; i++)
        {
            array2[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Calculate Sum into Third Array
        for (int i = 0; i < size; i++)
        {
            sumArray[i] = array1[i] + array2[i];
        }

        // Display the Result
        Console.WriteLine("The sum of the two arrays is:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(sumArray[i] + " ");
        }
    }
}2d
