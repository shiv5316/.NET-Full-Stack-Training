<<<<<<< HEAD
<<<<<<< HEAD
using System;
class Finance
{
    public static void find()
    {
        int choice;
        do
        {
            Console.WriteLine("Financial Control System"); 
            Console.WriteLine("1. Check Loan Eligibility"); 
            Console.WriteLine("2. Calculate tax");
            Console.WriteLine("3. Enter Transactions");
            Console.WriteLine("4. Exit from system");
            Console.Write("Enter your choice: ");
            choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                LoanEligibility();
                break;
                
                case 2:
                IncomeTax();
                break;
                
                case 3:
                Transactions();
                break;
                
                case 4:
                Console.WriteLine("Exiting....");
                break;
                
                default:
                Console.WriteLine("Invalid choice");
                break;
            }
            
        } while(choice!=4);
    }
    //LoanEligibility
    static void LoanEligibility()
    {
        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Monthly Income: ");
        double income = Convert.ToDouble(Console.ReadLine());

        if (age >= 21 && income >= 30000)
            Console.WriteLine("Loan Eligible");
        else
            Console.WriteLine("Not Eligible for Loan");
    }

    //Income Tax Calculation
    static void IncomeTax()
    {
        Console.Write("Enter Annual Income: ");
        double income = Convert.ToDouble(Console.ReadLine());
        double tax = 0;

        if (income <= 250000)
            tax = 0;
        else if (income <= 500000)
            tax = income * 0.05;
        else if (income <= 1000000)
            tax = income * 0.20;
        else
            tax = income * 0.30;

        Console.WriteLine("Income Tax = ₹" + tax);
    }

    //Transaction Entry
    static void Transactions()
    {
        Console.WriteLine("Enter 5 Transactions:");

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Transaction " + i + ": ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount < 0)
            {
                Console.WriteLine("Invalid Transaction! Skipped.");
                continue;
            }

            Console.WriteLine("Transaction Accepted: ₹" + amount);
        }
    }
}
=======
using System;
class Finance
{
    public static void find()
    {
        int choice;
        do
        {
            Console.WriteLine("Financial Control System"); 
            Console.WriteLine("1. Check Loan Eligibility"); 
            Console.WriteLine("2. Calculate tax");
            Console.WriteLine("3. Enter Transactions");
            Console.WriteLine("4. Exit from system");
            Console.Write("Enter your choice: ");
            choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                LoanEligibility();
                break;
                
                case 2:
                IncomeTax();
                break;
                
                case 3:
                Transactions();
                break;
                
                case 4:
                Console.WriteLine("Exiting....");
                break;
                
                default:
                Console.WriteLine("Invalid choice");
                break;
            }
            
        } while(choice!=4);
    }
    //LoanEligibility
    static void LoanEligibility()
    {
        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Monthly Income: ");
        double income = Convert.ToDouble(Console.ReadLine());

        if (age >= 21 && income >= 30000)
            Console.WriteLine("Loan Eligible");
        else
            Console.WriteLine("Not Eligible for Loan");
    }

    //Income Tax Calculation
    static void IncomeTax()
    {
        Console.Write("Enter Annual Income: ");
        double income = Convert.ToDouble(Console.ReadLine());
        double tax = 0;

        if (income <= 250000)
            tax = 0;
        else if (income <= 500000)
            tax = income * 0.05;
        else if (income <= 1000000)
            tax = income * 0.20;
        else
            tax = income * 0.30;

        Console.WriteLine("Income Tax = ₹" + tax);
    }

    //Transaction Entry
    static void Transactions()
    {
        Console.WriteLine("Enter 5 Transactions:");

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Transaction " + i + ": ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount < 0)
            {
                Console.WriteLine("Invalid Transaction! Skipped.");
                continue;
            }

            Console.WriteLine("Transaction Accepted: ₹" + amount);
        }
    }
}
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
=======
using System;
class Finance
{
    public static void find()
    {
        int choice;
        do
        {
            Console.WriteLine("Financial Control System"); 
            Console.WriteLine("1. Check Loan Eligibility"); 
            Console.WriteLine("2. Calculate tax");
            Console.WriteLine("3. Enter Transactions");
            Console.WriteLine("4. Exit from system");
            Console.Write("Enter your choice: ");
            choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                LoanEligibility();
                break;
                
                case 2:
                IncomeTax();
                break;
                
                case 3:
                Transactions();
                break;
                
                case 4:
                Console.WriteLine("Exiting....");
                break;
                
                default:
                Console.WriteLine("Invalid choice");
                break;
            }
            
        } while(choice!=4);
    }
    //LoanEligibility
    static void LoanEligibility()
    {
        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Monthly Income: ");
        double income = Convert.ToDouble(Console.ReadLine());

        if (age >= 21 && income >= 30000)
            Console.WriteLine("Loan Eligible");
        else
            Console.WriteLine("Not Eligible for Loan");
    }

    //Income Tax Calculation
    static void IncomeTax()
    {
        Console.Write("Enter Annual Income: ");
        double income = Convert.ToDouble(Console.ReadLine());
        double tax = 0;

        if (income <= 250000)
            tax = 0;
        else if (income <= 500000)
            tax = income * 0.05;
        else if (income <= 1000000)
            tax = income * 0.20;
        else
            tax = income * 0.30;

        Console.WriteLine("Income Tax = ₹" + tax);
    }

    //Transaction Entry
    static void Transactions()
    {
        Console.WriteLine("Enter 5 Transactions:");

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Transaction " + i + ": ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount < 0)
            {
                Console.WriteLine("Invalid Transaction! Skipped.");
                continue;
            }

            Console.WriteLine("Transaction Accepted: ₹" + amount);
        }
    }
}
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
