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
         int res=sum(num);
         Console.WriteLine(res);
    }
    public static int sum(int[] num)
    {
        int sum=0;
        for(int i=0;i<num.Length;i++)
        {
            sum+=num[i];
        }
        return sum;
    }
}