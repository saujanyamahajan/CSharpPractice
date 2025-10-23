using System;
using System.Linq;
using System.Collections.Generic;

class HelloWorld
{
    public static void Main()
    {
        int flag=1;
        int a = Convert.ToInt32(Console.ReadLine());
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