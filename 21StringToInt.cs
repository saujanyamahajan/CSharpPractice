// // //  String to integer conversion (without int.Parse)
// // // Approach :
// // // ASCII value of digits start from 48. So for each character , subtract 48 it will give corresponding digit.


// class Program
// {
//     public static void Main()
//     {
//         string str="Start";
//         int n=0;
//         for(int i=0; i<str.Length;i++)
//         {
//             n=(n*10)+((int)str[i]-48);
//         }
//         Console.WriteLine(n);
//     }
// }

// // int num = int.Parse(str);
