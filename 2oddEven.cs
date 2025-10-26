// using System;
// using System.Linq;
// using System.Collections.Generic;

// class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine("add a number");
//         string input=Console.ReadLine()??"";
//         int[] num = Array.ConvertAll(input.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
//         oddEven(num);
//     }
//     public static void oddEven(int[] num)
//     {
//         int even=0,odd=0;
//         for(int i=0;i<num.Length;i++)
//         {
//                 if(num[i]%2==0)
//                     even++;
//                 else
//                     odd++;
//         }
//         Console.WriteLine("even " + even);
//         Console.WriteLine("odd " + odd);
//     }
// }