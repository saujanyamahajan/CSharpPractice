// using System;
// using System.Collections.Generic;

// class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine("Enter an array:");
//         string input = Console.ReadLine() ?? "";
//         int[] num = Array.ConvertAll(input.Split(' '), int.Parse);
//         DupInArray(num);
//     }

//     public static void DupInArray(int[] num)
//     {
//         List<int> alist = new List<int>();
//         List<int> dups = new List<int>();

//         foreach (int a in num)
//         {
//             if (alist.Contains(a) && !dups.Contains(a))
//             {
//                 dups.Add(a);
//             }
//             else
//             {
//                 alist.Add(a);
//             }
//         }

//         if (dups.Count > 0)
//         {
//             Console.WriteLine("Duplicate elements:");
//             foreach (int i in dups)
//                 Console.WriteLine(i);
//         }
//         else
//         {
//             Console.WriteLine("No duplicates found.");
//         }
//     }
// }
