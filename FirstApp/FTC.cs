using System;

class FTC
{
    public static void calculate()
    {
        Console.Write("Enter feet: ");
        double feet=Convert.ToDouble(Console.ReadLine());
        double cm=feet*30.48;
        Console.WriteLine("Centimeters: "+cm);
    }
}