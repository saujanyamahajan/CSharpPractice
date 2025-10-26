// using System;
// using System.Linq;
// using System.Collections.Generic;

// class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine("Enter an array:");
//          string input = Console.ReadLine() ?? "";
//          int[] num = Array.ConvertAll(input.Split(' '), int.Parse);
//          numFrequency(num);
//     }
//     public static void numFrequency(int[] num)
//     {
//         Dictionary<int,int> dict =new Dictionary<int,int>();
//         for(int i=0;i<num.Length;i++)
//         {
//             if(dict.ContainsKey(num[i]))
//                 dict[num[i]]+=1;
//             else
//             dict.Add(num[i],1);
//         }
//         foreach(var kvp in dict)
//         {
//             Console.WriteLine($"{kvp.Key} = {kvp.Value}");
//         }
//     }
// }