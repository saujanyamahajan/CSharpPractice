using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    public static void Main()
    {
        Console.WriteLine("enter the number");
        string input = Console.ReadLine() ?? "0";   // Read as string
        int num = int.Parse(input);                 // Convert to int
        isPrime(num);
    }
    public static void isPrime(int a)
    {
            int flag=1;
            if(a<=1)
            flag=0;
            else
            {
                for(int i=2;i<=Math.Sqrt(a);i++)
                {
                    if(a%i==0)
                    {
                          flag=0;
                         break;
                    }
                }

            }
             if(flag==0)
                Console.WriteLine("Non prime");
                else
                Console.WriteLine("Prime");
    }
}