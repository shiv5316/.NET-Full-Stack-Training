using System;

class LON
{
    public static void calculate()
    {
        Console.Write("Enter first no: ");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second no: ");
        int b=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third no: ");
        int c=Convert.ToInt32(Console.ReadLine());
        
        if(a>b && a > c)
        {
            Console.WriteLine("Largest no is: "+a);
        }
        else if(b>a && b>c)
        {
            Console.WriteLine("Largest is: "+b);
        }
        else
        {
            Console.WriteLine("Largest is: "+c);
        }
    }

}