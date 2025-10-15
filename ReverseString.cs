using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
         Console.WriteLine("Enter an string:");
         string input = Console.ReadLine() ?? "";
         ReverseString(input);
    }
    public static void ReverseString(string ip)
    {
        char[] sarr = ip.ToCharArray();
        int i=0;
        int j=ip.Length-1;
        while(i<j)
        {
            char temp=sarr[i];
            sarr[i]=sarr[j];
            sarr[j]=temp;
            i++;
            j--;
        }
        Console.WriteLine("Reversed string:");
        Console.WriteLine(new string(sarr));
    }
}
