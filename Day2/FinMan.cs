<<<<<<< HEAD
<<<<<<< HEAD
using System;
using System.ComponentModel;
class Debit
{
    public static void WithdrawalLimit()
    {
        Console.Write("Enter WD Amount: ");
        int amount=Convert.ToInt32(Console.ReadLine());
        if(amount<=40000)
        Console.WriteLine("Withdrawal permitted within daily limit.");
        else
        Console.WriteLine("Daily ATM withdrawal limit exceeded.");       
        }
    
    public static void EMICheck()
    {
        Console.Write("Enter Monthly Income: ");
        double Income=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter EMI Amount: ");
        double EMI=Convert.ToDouble(Console.ReadLine());
        if(EMI<=Income*0.40)
        Console.WriteLine("EMI is financially manageable.");
        else
        Console.WriteLine("EMI exceeds safe income limit.");
    
        }
    public static void DailySpending()
    {
        Console.Write("Enter number of transaction: ");
        int n=Convert.ToInt32(Console.ReadLine());
        double total=0;
        for(int i = 0; i <= n; i++)
        {
            Console.Write("Enter amount " + i + ": ");
            total += Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Total debit amount for the day: " + total);

    }
    public static void MinimumBalance()
    {
        Console.Write("Enter current balance: ");
        double balance = Convert.ToDouble(Console.ReadLine());

        if (balance < 2000)
            Console.WriteLine("Minimum balance not maintained. Penalty applicable.");
        else
            Console.WriteLine("Minimum balance requirement satisfied.");
    }
}

class Credit
{
    public static void NetSalary()
    {
        Console.Write("Enter gross salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        double net = salary - (salary * 0.10);
        Console.WriteLine("Net salary credited: " + net);
    }
    public static void FDMaturity()
    {
        Console.Write("Enter principal: ");
        double p = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter rate: ");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter time (years): ");
        double t = Convert.ToDouble(Console.ReadLine());
        double interest = (p * r * t) / 100;
        Console.WriteLine("Fixed Deposit maturity amount: " + (p + interest));
    }

    public static void RewardPoints()
    {
        Console.Write("Enter total spending: ");
        int spend = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Reward points earned: " + (spend / 100));
    }

    public static void BonusCheck()
    {
        Console.Write("Enter annual salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter years of service: ");
        int years = Convert.ToInt32(Console.ReadLine());
        if (salary >= 500000 && years >= 3)
            Console.WriteLine("Employee is eligible for bonus.");
        else
            Console.WriteLine("Employee is not eligible for bonus.");
    }
}

class FinanceSystem
{
    public static void calculate()
    {
        int choice;
        do
        {
            Console.WriteLine("\n--- Finance Management System ---");
            Console.WriteLine("1. Debit Operations");
            Console.WriteLine("2. Credit Operations");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nDebit Menu");
                    Console.WriteLine("1. ATM Withdrawal");
                    Console.WriteLine("2. EMI Check");
                    Console.WriteLine("3. Daily Spending");
                    Console.WriteLine("4. Minimum Balance");
                    int d = Convert.ToInt32(Console.ReadLine());
                    if (d == 1) Debit.WithdrawalLimit();
                    else if (d == 2) Debit.EMICheck();
                    else if (d == 3) Debit.DailySpending();
                    else if (d == 4) Debit.MinimumBalance();
                    break;
                case 2:
                    Console.WriteLine("\nCredit Menu");
                    Console.WriteLine("1. Net Salary");
                    Console.WriteLine("2. FD Maturity");
                    Console.WriteLine("3. Reward Points");
                    Console.WriteLine("4. Bonus Eligibility");
                    int c = Convert.ToInt32(Console.ReadLine());
                    if (c == 1) Credit.NetSalary();
                    else if (c == 2) Credit.FDMaturity();
                    else if (c == 3) Credit.RewardPoints();
                    else if (c == 4) Credit.BonusCheck();
                    break;
                case 3:
                    Console.WriteLine("Program exited.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        } while (choice != 3);
    }
}
    
=======
using System;
using System.ComponentModel;
class Debit
{
    public static void WithdrawalLimit()
    {
        Console.Write("Enter WD Amount: ");
        int amount=Convert.ToInt32(Console.ReadLine());
        if(amount<=40000)
        Console.WriteLine("Withdrawal permitted within daily limit.");
        else
        Console.WriteLine("Daily ATM withdrawal limit exceeded.");       
        }
    
    public static void EMICheck()
    {
        Console.Write("Enter Monthly Income: ");
        double Income=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter EMI Amount: ");
        double EMI=Convert.ToDouble(Console.ReadLine());
        if(EMI<=Income*0.40)
        Console.WriteLine("EMI is financially manageable.");
        else
        Console.WriteLine("EMI exceeds safe income limit.");
    
        }
    public static void DailySpending()
    {
        Console.Write("Enter number of transaction: ");
        int n=Convert.ToInt32(Console.ReadLine());
        double total=0;
        for(int i = 0; i <= n; i++)
        {
            Console.Write("Enter amount " + i + ": ");
            total += Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Total debit amount for the day: " + total);

    }
    public static void MinimumBalance()
    {
        Console.Write("Enter current balance: ");
        double balance = Convert.ToDouble(Console.ReadLine());

        if (balance < 2000)
            Console.WriteLine("Minimum balance not maintained. Penalty applicable.");
        else
            Console.WriteLine("Minimum balance requirement satisfied.");
    }
}

class Credit
{
    public static void NetSalary()
    {
        Console.Write("Enter gross salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        double net = salary - (salary * 0.10);
        Console.WriteLine("Net salary credited: " + net);
    }
    public static void FDMaturity()
    {
        Console.Write("Enter principal: ");
        double p = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter rate: ");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter time (years): ");
        double t = Convert.ToDouble(Console.ReadLine());
        double interest = (p * r * t) / 100;
        Console.WriteLine("Fixed Deposit maturity amount: " + (p + interest));
    }

    public static void RewardPoints()
    {
        Console.Write("Enter total spending: ");
        int spend = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Reward points earned: " + (spend / 100));
    }

    public static void BonusCheck()
    {
        Console.Write("Enter annual salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter years of service: ");
        int years = Convert.ToInt32(Console.ReadLine());
        if (salary >= 500000 && years >= 3)
            Console.WriteLine("Employee is eligible for bonus.");
        else
            Console.WriteLine("Employee is not eligible for bonus.");
    }
}

class FinanceSystem
{
    public static void calculate()
    {
        int choice;
        do
        {
            Console.WriteLine("\n--- Finance Management System ---");
            Console.WriteLine("1. Debit Operations");
            Console.WriteLine("2. Credit Operations");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nDebit Menu");
                    Console.WriteLine("1. ATM Withdrawal");
                    Console.WriteLine("2. EMI Check");
                    Console.WriteLine("3. Daily Spending");
                    Console.WriteLine("4. Minimum Balance");
                    int d = Convert.ToInt32(Console.ReadLine());
                    if (d == 1) Debit.WithdrawalLimit();
                    else if (d == 2) Debit.EMICheck();
                    else if (d == 3) Debit.DailySpending();
                    else if (d == 4) Debit.MinimumBalance();
                    break;
                case 2:
                    Console.WriteLine("\nCredit Menu");
                    Console.WriteLine("1. Net Salary");
                    Console.WriteLine("2. FD Maturity");
                    Console.WriteLine("3. Reward Points");
                    Console.WriteLine("4. Bonus Eligibility");
                    int c = Convert.ToInt32(Console.ReadLine());
                    if (c == 1) Credit.NetSalary();
                    else if (c == 2) Credit.FDMaturity();
                    else if (c == 3) Credit.RewardPoints();
                    else if (c == 4) Credit.BonusCheck();
                    break;
                case 3:
                    Console.WriteLine("Program exited.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        } while (choice != 3);
    }
}
    
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
=======
using System;
using System.ComponentModel;
class Debit
{
    public static void WithdrawalLimit()
    {
        Console.Write("Enter WD Amount: ");
        int amount=Convert.ToInt32(Console.ReadLine());
        if(amount<=40000)
        Console.WriteLine("Withdrawal permitted within daily limit.");
        else
        Console.WriteLine("Daily ATM withdrawal limit exceeded.");       
        }
    
    public static void EMICheck()
    {
        Console.Write("Enter Monthly Income: ");
        double Income=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter EMI Amount: ");
        double EMI=Convert.ToDouble(Console.ReadLine());
        if(EMI<=Income*0.40)
        Console.WriteLine("EMI is financially manageable.");
        else
        Console.WriteLine("EMI exceeds safe income limit.");
    
        }
    public static void DailySpending()
    {
        Console.Write("Enter number of transaction: ");
        int n=Convert.ToInt32(Console.ReadLine());
        double total=0;
        for(int i = 0; i <= n; i++)
        {
            Console.Write("Enter amount " + i + ": ");
            total += Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Total debit amount for the day: " + total);

    }
    public static void MinimumBalance()
    {
        Console.Write("Enter current balance: ");
        double balance = Convert.ToDouble(Console.ReadLine());

        if (balance < 2000)
            Console.WriteLine("Minimum balance not maintained. Penalty applicable.");
        else
            Console.WriteLine("Minimum balance requirement satisfied.");
    }
}

class Credit
{
    public static void NetSalary()
    {
        Console.Write("Enter gross salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        double net = salary - (salary * 0.10);
        Console.WriteLine("Net salary credited: " + net);
    }
    public static void FDMaturity()
    {
        Console.Write("Enter principal: ");
        double p = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter rate: ");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter time (years): ");
        double t = Convert.ToDouble(Console.ReadLine());
        double interest = (p * r * t) / 100;
        Console.WriteLine("Fixed Deposit maturity amount: " + (p + interest));
    }

    public static void RewardPoints()
    {
        Console.Write("Enter total spending: ");
        int spend = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Reward points earned: " + (spend / 100));
    }

    public static void BonusCheck()
    {
        Console.Write("Enter annual salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter years of service: ");
        int years = Convert.ToInt32(Console.ReadLine());
        if (salary >= 500000 && years >= 3)
            Console.WriteLine("Employee is eligible for bonus.");
        else
            Console.WriteLine("Employee is not eligible for bonus.");
    }
}

class FinanceSystem
{
    public static void calculate()
    {
        int choice;
        do
        {
            Console.WriteLine("\n--- Finance Management System ---");
            Console.WriteLine("1. Debit Operations");
            Console.WriteLine("2. Credit Operations");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nDebit Menu");
                    Console.WriteLine("1. ATM Withdrawal");
                    Console.WriteLine("2. EMI Check");
                    Console.WriteLine("3. Daily Spending");
                    Console.WriteLine("4. Minimum Balance");
                    int d = Convert.ToInt32(Console.ReadLine());
                    if (d == 1) Debit.WithdrawalLimit();
                    else if (d == 2) Debit.EMICheck();
                    else if (d == 3) Debit.DailySpending();
                    else if (d == 4) Debit.MinimumBalance();
                    break;
                case 2:
                    Console.WriteLine("\nCredit Menu");
                    Console.WriteLine("1. Net Salary");
                    Console.WriteLine("2. FD Maturity");
                    Console.WriteLine("3. Reward Points");
                    Console.WriteLine("4. Bonus Eligibility");
                    int c = Convert.ToInt32(Console.ReadLine());
                    if (c == 1) Credit.NetSalary();
                    else if (c == 2) Credit.FDMaturity();
                    else if (c == 3) Credit.RewardPoints();
                    else if (c == 4) Credit.BonusCheck();
                    break;
                case 3:
                    Console.WriteLine("Program exited.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        } while (choice != 3);
    }
}
    
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
