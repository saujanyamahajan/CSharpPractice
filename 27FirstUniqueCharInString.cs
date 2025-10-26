// using System;
// using System.Linq;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter a string:");
//         string input=Console.ReadLine()??"";
//          frequencyOfChar(input);

//     }
//     public static void frequencyOfChar(string input)
//     {
//         Dictionary<char,int> dict = new Dictionary<char,int>();
//         for(int i=0;i<input.Length;i++)
//         {
//             if (input[i] == ' ') continue; // skip spaces
//             if(dict.ContainsKey(input[i]))
//                 dict[input[i]]+=1;
//             else
//                 dict.Add(input[i],1);
//         }
//         foreach(var kvp in dict)
//         {
//             if(kvp.Value==1)
//             {
//                 Console.WriteLine(kvp.Key);
//                 break;
//             }
//             else
//             Console.WriteLine("Not Found");
//         }
//     }
// }