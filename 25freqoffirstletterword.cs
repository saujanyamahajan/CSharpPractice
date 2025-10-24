using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        string str="My name is Saujanya Mahajan";
        string[] arr=str.Split(' ');
        Dictionary<char,List<string>> dict= new Dictionary<char,List<string>>();
        foreach (string word in arr)
        {
        char firstChar = char.ToUpper(word[0]);
     
        if(!dict.ContainsKey(firstChar))
                dict[firstChar]=new List<string>();
                
        dict[firstChar].Add(word);
        }
        foreach(var kvp in dict)
        {
            Console.WriteLine($"{kvp.Key}: {string.Join(", ", kvp.Value)}");
        }
    }
}