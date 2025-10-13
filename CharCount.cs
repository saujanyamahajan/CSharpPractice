using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine() ?? "";
        charCount(input);
    }

    public static void charCount(string ip)
    {
        Dictionary<char,int> dict= new Dictionary<char,int>();
                ip = ip.ToLower();
        foreach(char c in ip)
        {
                if (c == ' ') // skip spaces
                continue;

            if(dict.ContainsKey(c))
            {
                dict[c]++;
            }
            else dict[c]=1;
        }

        foreach(var kvp in dict)
        Console.WriteLine($"{kvp.Key}={kvp.Value}");
    }
}