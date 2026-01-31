using System;
class Program
{
    public static int SumOnlyInt(object[] values)
    {
        int sum=0;
        foreach(object item in values)
        {
            if(item is int x)
            {
                sum+=x;
            }
        }
        return sum;
    }
    static void Main()
    {
        object[] values = { 10, "hello", true, null, 25, 5.5, 40 };
        int result = SumOnlyInt(values);
        Console.WriteLine("Sum of integers: " + result);
    }
}
