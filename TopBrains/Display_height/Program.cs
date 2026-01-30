using System;
using System.Data;
class Program
{
    static string GetHeight(int heightcm)
    {
        if(heightcm<150)
        return "Short";
        else if(heightcm<180)
        return "Average";
        else
        return "Tall";
    }
    static void Main()
    {
        int heightcm=int.Parse(Console.ReadLine());
        Console.WriteLine(GetHeight(heightcm));
    }
}
