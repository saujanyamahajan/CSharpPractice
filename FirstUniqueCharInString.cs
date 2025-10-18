using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        String str = "hello";
        Dictionary<char,int> dict = new Dictionary<char,int>();
        for(int i=0;i<str.Length;i++)
        {
            if(dict.ContainsKey(str[i]))
            {
                dict[str[i]]+=1;
            }
            else
            dict.Add(str[i],1);
        }
        foreach(KeyValuePair<char,int> ele in dict)
        {
            if(ele.Value==1)
            {
                Console.WriteLine(ele.Key);
                break;
            }
            else
            {
                Console.WriteLine("Not Found!");
            }
        }
    }
}
