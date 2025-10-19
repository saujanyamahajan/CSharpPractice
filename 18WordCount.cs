// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter a string: ");
//         string input = Console.ReadLine() ?? "";
        
//         var dict = new Dictionary<char, int>();

//         foreach (char c in input)
//         {
//             if (dict.ContainsKey(c))
//                 dict[c]++;
//             else
//                 dict[c] = 1;
//         }

//         Console.WriteLine("Duplicate characters:");
//         foreach (var pair in dict)
//         {
//             if (pair.Value > 1)
//                 Console.WriteLine($"{pair.Key} → {pair.Value}");
//         }
//     }
// }
