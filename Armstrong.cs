using System;
using System.Linq;
using System.Collections.Generic;

class HelloWorld
{
    public static void Main()
    {
         Console.WriteLine("Enter an num:");
        int a = Convert.ToInt32(Console.ReadLine());
        int digits=0;
        int temp=a;
        int temp2=a;
        int result=0;
        while(temp>0)
        {
            digits++;
            temp=temp/10;
        }
        while(a>0)
        {
            result+=(int)Math.Pow(a%10,digits);
            a=a/10;
        }
        if(temp2==result)
        Console.WriteLine("Armstrong!");
        else
        Console.WriteLine("Non Armstrong!");
    }
}
