using System;
class Program
{
    static int Largestinteger(int a,int b,int c)
    {
        int largest;
        if (a >= b && a >= c)
        {
            largest=a;
        }else if (b >= a && b >= c)
        {
            largest=b;
        }
        else
        {
            largest=c;
        }
        return largest;
    }
    static void Main()
    {
        string[] input=Console.ReadLine().Split();
        int a=int.Parse(input[0]);
        int b=int.Parse(input[1]);
        int c=int.Parse(input[2]);
        Console.WriteLine(Largestinteger(a,b,c));
    }
}
