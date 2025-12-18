using System;
class STM
{
    public static void calculate()
    {
        Console.Write("Enter sec: ");
        int sec=Convert.ToInt32(Console.ReadLine());
        double min=sec/60;
        Console.WriteLine("Minutes: "+min);
    }
}