using System;
class Program
{
    // static void SwapRef(ref int a, ref int b)
    // {
    //    a=a+b;
    //    b=a-b;
    //    a=a-b;
    // }
    static void SwapOut(int a,int b,out int newA,out int newB)
    {
        newA=b;
        newB=a;
    }
    static void Main()
    {
        int x=35;
        int y=45;
        Console.WriteLine("Before Swapping:x="+x+",y="+y);
        //SwapRef(ref x,ref y);
        SwapOut(x,y,out x,out y);
        Console.WriteLine("After Swapping:x="+x+",y="+y);
    }
}