using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter an array:");
         string input = Console.ReadLine() ?? "";
         int[] num = Array.ConvertAll(input.Split(' '), int.Parse);
         oddEven(num);
    }
    public static void oddEven(int[] num)
    {
        int even=0;
        int odd=0;
        foreach(int i in num)
        {
            if(i%2==0)
            even++;
            else
            odd++;
        }
        Console.WriteLine("odd:"+odd);
        Console.WriteLine("even:"+even);

    }
}