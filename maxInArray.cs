// using System;
// using System.Collections.Generic;

// class Program
// {
//     public static void Main()
//     {
//         Console.Write("Enter an array: ");
//         string input = Console.ReadLine() ?? "";

//         int[] num = Array.ConvertAll(input.Split(' '), int.Parse);
//         int res = MaxArray(num);

//         Console.WriteLine(res);
//     }

//     public static int MaxArray(int[] num)
//     {
//         int max = int.MinValue;

//         foreach (int i in num)
//         {
//             if (i > max)
//                 max = i;
//         }

//         return max;
//     }
// }
