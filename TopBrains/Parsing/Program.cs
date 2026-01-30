using System;
class Program
{
    static int SumValidInt(string[] tokens)
    {
        int sum=0;
        foreach(string token in tokens)
        {
           if(int.TryParse(token,out int value))
            {
                sum+=value;
            } 
        }
        return sum;
    }
    static void Main()
    {
        string[] tokens={"10","abc","200","999999999999","-5"};
        Console.WriteLine(SumValidInt(tokens));
    }
}
