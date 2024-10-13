using System;

class Program
{
    static void Main()
    {
         Console.Write("Enter a array: ");
        string input = Console.ReadLine() ?? "";
                int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);
        int result = secondHighest(numbers);
        Console.WriteLine(result);

    }
    public static int secondHighest(int[] nums)
    {
        int first= int.MinValue, second=int.MinValue;
        foreach(int n in nums)
        {
            if(n>first)
            {
                second=first;
                first=n;
            }
            else if(n>second && first!=n)
            {
                second=n;
            }
        }
        return second;
    }
}