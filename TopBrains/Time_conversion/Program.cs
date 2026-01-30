using System;
class Program
{
    static string FormatTime(int totalSec)
    {
        int min=totalSec/60;
        int sec=totalSec%60;
        return min+":"+sec.ToString("D2");
    }
    static void Main()
    {
        int totalSec=int.Parse(Console.ReadLine());
        Console.WriteLine(FormatTime(totalSec));
    }
}