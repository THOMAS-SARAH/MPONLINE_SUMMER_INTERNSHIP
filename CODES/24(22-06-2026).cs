//WAP To show Nullable<int> behaves when you assign null, compare it with another nullable, and use the HasValue and GetValueOrDefault properties.

using System;

class NullableDemo
{
    public static void Show()
    {
        int? n1 = null;
        int? n2 = 10;
        int? n3 = null;

        Console.WriteLine("n1 = " + n1);
        Console.WriteLine("n2 = " + n2);

        Console.WriteLine("n1 == n3 : " + (n1 == n3));
        Console.WriteLine("n1 == n2 : " + (n1 == n2));

        Console.WriteLine("n1 HasValue : " + n1.HasValue);
        Console.WriteLine("n2 HasValue : " + n2.HasValue);

        Console.WriteLine("n1 GetValueOrDefault : " + n1.GetValueOrDefault());
        Console.WriteLine("n2 GetValueOrDefault : " + n2.GetValueOrDefault());
    }
}

//program class

using System;

class Program
{
    static void Main()
    {
        NullableDemo.Show();
    }
}
