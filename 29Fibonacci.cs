using System;
using System.Linq;
using System.Collections.Generic;

class HelloWorld
{
    public static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int first=0,second=1,next=0;
        for(int i=0;i<a;i++)
        {
            if(i<=1)
            next=i;
            else
            {
                next=first+second;
                first=second;
                second=next;
            }
            Console.WriteLine(next + " ");
        }
    }
}

