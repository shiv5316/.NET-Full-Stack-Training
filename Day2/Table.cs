using System;
class Table
{
    public static void calculate()
    {
        // for(int a = 20; a <= 30; a++)
        // {
        // for(int i = 0; i <= 10; i++)
        // {
        //     Console.WriteLine($"{a} x {i}={i*a}");
        // }
        // }
    // Break with loop    
        for(int i = 1; i <= 10; i++)
        {
            if (i == 5)
                break;
            Console.WriteLine(i);
        }
    }
}