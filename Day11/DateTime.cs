using System;
using System.Text;
class Program1
{
    public static void calculate()
    {
        // DateTime now = DateTime.Now;
        // DateTime today = DateTime.Today;     // Date only (time = 00:00:00)
        // DateTime utcNow = DateTime.UtcNow;   // Coordinated Universal Time
        // DateTime custom = new DateTime(2025, 1, 10, 14, 30, 0);
        // Console.WriteLine("Now       : " + now);
        // Console.WriteLine("Today     : " + today);
        // Console.WriteLine("UTC Now   : " + utcNow);
        // Console.WriteLine("Custom DT : " + custom);


        DateTime now = DateTime.Now;
        int year  = now.Year;
        int month = now.Month;
        int day   = now.Day;
        int hour  = now.Hour;
        int min   = now.Minute;
        int sec   = now.Second;

        Console.WriteLine("Year   : " + year);
        Console.WriteLine("Month  : " + month);
        Console.WriteLine("Day    : " + day);
        Console.WriteLine("Hour   : " + hour);
        Console.WriteLine("Minute : " + min);
        Console.WriteLine("Second : " + sec);

        // Date Manipulation
        DateTime future = now.AddDays(10);

        Console.WriteLine("\nCurrent Date: " + now);
        Console.WriteLine("Future Date : " + future);


    }

}

