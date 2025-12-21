<<<<<<< HEAD
<<<<<<< HEAD
using System;

class DepositAccount
{
    double balance = 20000; 

    public void DepositAmount(double amount)
    {
        balance = balance + amount;
        Console.WriteLine("Deposit successful");
        Console.WriteLine("Updated balance: " + balance);
    }
}

class Depositt
{
    public static void calculate()
    {
        DepositAccount acc = new DepositAccount();

        Console.Write("Enter deposit amount: ");
        double amt = Convert.ToDouble(Console.ReadLine());

        acc.DepositAmount(amt);
    }
}
=======
using System;

class DepositAccount
{
    double balance = 20000; 

    public void DepositAmount(double amount)
    {
        balance = balance + amount;
        Console.WriteLine("Deposit successful");
        Console.WriteLine("Updated balance: " + balance);
    }
}

class Depositt
{
    public static void calculate()
    {
        DepositAccount acc = new DepositAccount();

        Console.Write("Enter deposit amount: ");
        double amt = Convert.ToDouble(Console.ReadLine());

        acc.DepositAmount(amt);
    }
}
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
=======
using System;

class DepositAccount
{
    double balance = 20000; 

    public void DepositAmount(double amount)
    {
        balance = balance + amount;
        Console.WriteLine("Deposit successful");
        Console.WriteLine("Updated balance: " + balance);
    }
}

class Depositt
{
    public static void calculate()
    {
        DepositAccount acc = new DepositAccount();

        Console.Write("Enter deposit amount: ");
        double amt = Convert.ToDouble(Console.ReadLine());

        acc.DepositAmount(amt);
    }
}
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
