using System;
class Program
{
    public static void Main()
    {
        Console.Write("Enter an array: ");
        string input = Console.ReadLine() ?? "";
        int[] num = Array.ConvertAll(input.Split(' '), int.Parse);
        int result = ThirdHighest(num);
        Console.WriteLine(result);
    }
    public static int ThirdHighest(int[] num)
    { 
        int max = int.MinValue;
        int secondMax = int.MinValue;
        int thirdMax = int.MinValue;
        foreach(int i in num)
        {
            if(i>max)
            {
                thirdMax = secondMax;
                secondMax=max;
                max=i;
            }
            else if(i>secondMax && i!=max)
            {
                thirdMax=secondMax;
                secondMax=i;
            }
            else if(i>thirdMax && i!=secondMax && i!= max)
            {
                thirdMax=i;
            }
        }
        return thirdMax;
    }
}