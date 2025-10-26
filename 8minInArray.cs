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
         int res=MinArray(num);
         Console.WriteLine(res);
    }
    public static int MinArray(int[] num)
    {
        int min=int.MaxValue;
        for(int i=0;i<num.Length;i++)
        {
            if(num[i]<min)
            {
                min=num[i];
            }
        }
        return min;
    }
}