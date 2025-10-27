// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter a string");
//         string input=Console.ReadLine()??"";

//         Dictionary<char,int> dict=new Dictionary<char,int>();
//         for(int i=0;i<input.Length;i++)
//         {
//             if(dict.ContainsKey(input[i]))
//                 dict[input[i]]++;
//             else
//                 dict[input[i]]=1;
//         }
//         Console.WriteLine("Duplicate characters:");
//         foreach(var kvp in dict)
//         {
//             if(kvp.Value>1)
//             Console.WriteLine($"{kvp.Key}={kvp.Value}");
//         }
//     }
// }