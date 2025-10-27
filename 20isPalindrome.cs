using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine() ?? "";


        bool result = IsPalindrome(input);

        if (result)
            Console.WriteLine("The string is a palindrome!");
        else
            Console.WriteLine("The string is not a palindrome.");

////RETURNING STRING
        // char[] result = new char[input.Length];
        // int left = 0, right = input.Length - 1;

        // while (right >= 0)
        // {
        //     result[left++] = input[right--];
        // }

        // Console.WriteLine("Reversed string: " + new string(result));
    }

    static bool IsPalindrome(string input)
    {
        int left=0,right=input.Length-1;

        while(right>left)
        {
          if(input[left++]!=input[right--])
           return false;
        }
        return true;
    }
}

