using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Console.WriteLine("enter an array");
         string input = Console.ReadLine() ?? "";
         int[] num = Array.ConvertAll(input.Split(' '), int.Parse);
         int res=MaxArray(num);
         Console.WriteLine(res);
    }
    public static int MaxArray(int[] num)
    {
        int max=int.MinValue;
        for(int i=0; i<num.Length;i++)
        {
            if(num[i]>max)
            {
                max=num[i];
            }
        }
        return max;
    }
}