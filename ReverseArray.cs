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
         ReverseArray(num);
    }
    public static void ReverseArray(int[] arr)
    {
        int i=0;
        int j=arr.Length-1;
        while(i<j)
        {
            int temp=arr[i];
            arr[i]=arr[j];
            arr[j]=temp;
            i++;
            j--;
        }
        foreach(int a in arr)
        {
            Console.Write(a + " ");
        }
    }
}
