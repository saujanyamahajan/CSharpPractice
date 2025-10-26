using System;
using System.Linq;
using System.Collections.Generic;



class Program
{
    public static void Main()
    {
        int[] arr= {1,3,4,5};
        int n=arr.Length+1;
        int sum=0;
        int expectedSum=(n*(n+1))/2;
        for(int i=0;i<arr.Length;i++)
        {
            sum+=arr[i];
        }
        int res=expectedSum-sum;
        Console.WriteLine(res);
    }
}