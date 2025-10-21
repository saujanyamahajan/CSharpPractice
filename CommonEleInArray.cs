using System;
using System.Linq;
using System.Collections.Generic;

class HelloWorld
{
    public static void Main()
    {
        int[] arr1 = {1,2,4,5,0};
        int[] arr2 = {2,5,9,10,11,22,14,15};
        List<int> alist = new List<int>();
        List<int> result = new List<int>();
        foreach(int i in arr1)
        alist.Add(i);
        foreach(int j in arr2)
        {
            if(alist.Contains(j))
            result.Add(j);
        }
        foreach(int k in result)
        Console.WriteLine(k);
    }
}
