using System;
class Program
{
    static double FeetToCm(int feet)
    {
        double cm=feet*30.48;
        return Math.Round(cm,2,MidpointRounding.AwayFromZero);
    }
    static void Main()
    {
        int feet=int.Parse(Console.ReadLine());
        Console.WriteLine(FeetToCm(feet));
    }
}
