// using System;
// using System.Linq;
// using System.Collections.Generic;


// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter arr 1");
//         string input1 = Console.ReadLine() ?? "";
//         int[] num1 = Array.ConvertAll(input1.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);

//         Console.WriteLine("Enter arr 2");
//         string input2 = Console.ReadLine() ?? "";
//         int[] num2 = Array.ConvertAll(input1.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
//         CommonEleInArray(num1,num2);
//     }
//     public static void CommonEleInArray(int[] num1,int[] num2)
//     {
//         List<int> list= new List<int>();
//         List<int> result= new List<int>();
//         foreach(int i in num1)
//         {
//             list.Add(i);
//         }
//         foreach(int j in num2)
//         {
//             if(list.Contains(j))
//                 result.Add(j);
//         }
//          foreach(int k in result)
//          Console.WriteLine(k);

//     }
// }