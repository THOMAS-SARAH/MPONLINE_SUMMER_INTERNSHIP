//Password encoding/decoding based on following rules
• Encodes it by:
• Shifting each character by +2 in the ASCII table (e.g., A → C, b → d).
• Reversing the entire string after shifting.
• Decodes it back to the original message by reversing the process.

  using System;

class PasswordEncoder
{
    public static string Encode(string text)
    {
        char[] arr = new char[text.Length];

        for (int i = 0; i < text.Length; i++)
            arr[i] = (char)(text[i] + 2);

        Array.Reverse(arr);
        return new string(arr);
    }

    public static string Decode(string text)
    {
        char[] arr = text.ToCharArray();
        Array.Reverse(arr);

        for (int i = 0; i < arr.Length; i++)
            arr[i] = (char)(arr[i] - 2);

        return new string(arr);
    }
}

//program class

using System;

class Program
{
    static void Main()
    {
        string password = "Hello123";

        string encoded = PasswordEncoder.Encode(password);
        string decoded = PasswordEncoder.Decode(encoded);

        Console.WriteLine("Original : " + password);
        Console.WriteLine("Encoded  : " + encoded);
        Console.WriteLine("Decoded  : " + decoded);
    }
}
