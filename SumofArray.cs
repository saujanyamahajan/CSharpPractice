using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter an array:");
        string input = Console.ReadLine() ?? "";
        int[] num = Array.ConvertAll(input.Split(' '), int.Parse);
        int res = sum(num);
        Console.WriteLine(res);
    }
    public static int sum(int[] num)
    {
        int sum=0;
        foreach(int i in num)
        {
            sum=sum+i;
        }
        return sum;
    }
}