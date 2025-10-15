// using System;
// using System.Linq;
// using System.Collections.Generic;

// class Program
// {
//     public static void Main()
//     {
//          Console.Write("Enter an array: ");
//         string input = Console.ReadLine() ?? "";
//         int[] num = Array.ConvertAll(input.Split(' '), int.Parse);

//         int[] result = RemoveDuplicate(num);

//         Console.WriteLine("Array after removing duplicates:");
//         foreach (int i in result)
//             Console.Write(i + " ");
//     }

//     public static int[] RemoveDuplicate(int[] arr)
//     {
//     List<int> nlist = new List<int>();
//     foreach(int i in arr)
//     {
//         if(!nlist.Contains(i))
//         nlist.Add(i);
//     }
//            return nlist.ToArray();

//     }
    
// }