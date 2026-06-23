//Convert hours to days days = h / 24

using System;

class HoursConverter
{
    public static void ConvertToDays(int hours)
    {
        int days = hours / 24;
        Console.WriteLine("Days = " + days);
    }
}

//program class

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter hours: ");
        int hours = int.Parse(Console.ReadLine());

        HoursConverter.ConvertToDays(hours);
    }
}
