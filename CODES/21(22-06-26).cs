using System;
using System.Collections.Generic;

class Anagram
{
    public static void PrintGroups(string[] words)
    {
        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

        foreach (string word in words)
        {
            char[] arr = word.ToCharArray();
            Array.Sort(arr);
            string key = new string(arr);

            if (!groups.ContainsKey(key))
                groups[key] = new List<string>();

            groups[key].Add(word);
        }

        foreach (var group in groups.Values)
            Console.WriteLine(string.Join(" ", group));
    }
}

// program class

using System;

class Program
{
    static void Main()
    {
        string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };
        Anagram.PrintGroups(words);
    }
}
