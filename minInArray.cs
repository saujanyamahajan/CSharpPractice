using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Console.Write("Enter an array : ");
        string input = Console.ReadLine() ?? "";

        int[] num = Array.ConvertAll(input.Split(' '), int.Parse);
        int res = MinArray(num);

        Console.WriteLine(res);
    }

    public static int MinArray(int[] num)
    {
        int min = int.MaxValue;

        foreach (int i in num)
        {
            if (i < min)
                min = i;
        }

        return min;
    }
}
