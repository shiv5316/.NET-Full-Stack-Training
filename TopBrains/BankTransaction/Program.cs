using System;
class Program
{
    public static int BankTransaction(int initialBalance,int[] transactions)
    {
        int balance=initialBalance;
        foreach(int t in transactions)
        {
            if(t>=0)
            {
                balance+=t;
            }
            else
            {
                if (balance + t >= 0)
                {
                    balance+=t;
                }
            }
        }
        return balance;
    }
    static void Main()
    {
        int initialBalance=100;
        int[] transaction={50,-30,-150,20};
        int finalBalance=BankTransaction(initialBalance,transaction);
        Console.WriteLine("Final Balance: "+finalBalance);
    }
}
