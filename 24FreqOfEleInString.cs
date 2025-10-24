// using System;
// using System.Linq;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         string str= "holaa amigo yo yo ok ok";
//         string[] arr = str.Split(' '); // Split by space
//         Dictionary<string, int> dict = new Dictionary<string, int>();
//         for (int i = 0; i < arr.Length; i++)
//         {
//             if (string.IsNullOrWhiteSpace(arr[i]))
//                 continue;
//             if (dict.ContainsKey(arr[i]))
//                 dict[arr[i]] += 1;
//             else
//                 dict.Add(arr[i], 1);
//         }
//         foreach(var kvp in dict)
//         {
//             Console.WriteLine($"{kvp.Key} = {kvp.Value}");
//         }
//     }
// }