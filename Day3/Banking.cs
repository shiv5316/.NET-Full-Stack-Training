using System;
class BankAccount
{
    public int AccNum;
    public double Balance;
    
}
class Banking
{
    public static void calculate()
    {
        BankAccount acc1=new BankAccount();
        acc1.AccNum=101;
        acc1.Balance=10000;
        Console.WriteLine("Account Number: " + acc1.AccNum);
        Console.WriteLine("Balance: " + acc1.Balance);
    }
}
