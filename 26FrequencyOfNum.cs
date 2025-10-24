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
         numFrequency(num);
    }
    public static void numFrequency(int[] num)
    {
        Dictionary<int,int> dict = new Dictionary<int,int>();
         foreach(int a in num)
         {
            if(dict.ContainsKey(a))
            {
                dict[a]+=1;
            }
            else
            {
                dict.Add(a,1);
            }
         }
         foreach(KeyValuePair<int,int> ele in dict.OrderBy(e=>e.Key))
         {
            Console.WriteLine("Element : {0} - Frequency : {1}",ele.Key,ele.Value);
         }
    }
}