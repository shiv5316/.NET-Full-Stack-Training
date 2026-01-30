using System;
class Program
{
    static int SumPositive(int[] nums)
    {
        int sum=0;
        foreach(int num in nums)
        {
            if(num==0)
            break;
            if(num<0)
            continue;
            sum+=num;
        }
        return sum;
    }
    static void Main()
    {
        int[] nums={5,-2,10,-3,7,0,8};
        Console.WriteLine(SumPositive(nums));
    }
}
