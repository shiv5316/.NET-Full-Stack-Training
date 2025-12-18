using System;
class SOD
{
    public static void calculate()
    {
        int n=1234;
        // int sum =0;
        int reverse=0;
        while(n>0)
        {
             int digit=n%10;
             n=n/10;
            //  sum+=digit;
            reverse=reverse*10+digit;
            
        }
        // Console.WriteLine("Sum of digits:"+sum);
        Console.WriteLine("Reversed no: "+reverse);
    }
}