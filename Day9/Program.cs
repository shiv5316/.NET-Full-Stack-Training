<<<<<<< HEAD
<<<<<<< HEAD
﻿using System;
using System.Dynamic;
using System.IO;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
// class Program
// {
//     static void Main()
//     {
//         int a=10;
//         int b=0;
//         try
//         {
//             int result=a/b;
//         }catch(Exception ex)
//         {
//             Console.WriteLine("Error occured: "+ex.Message);
//         }
//     }
// }
/*
class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string Message) : base(Message){ }
}
class BankAccount
{
    public decimal Balance{get; private set;}=5000;
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be greater that zero");
        if(amount > Balance)
        throw new InsufficientBalanceException("Insufficient balance for withdrawal");
        Balance -= amount;
    }
}
class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter withdrawal amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            int serviceCharge = 100;
            //int divisionCheck = serviceCharge / int.Parse("0"); 

            string data = File.ReadAllText("error.log");

            BankAccount account = new BankAccount();
            account.Withdraw(amount);

            Console.WriteLine("Withdrawal successful.");

        }
        catch(FormatException ex)
        {
            LogException(ex);
            Console.WriteLine("Invalid input format.");
        }
        catch (DivideByZeroException ex)
        {
            LogException(ex);
            Console.WriteLine("Cannot divide by zero.");
        }
        catch (FileNotFoundException ex)
        {
            LogException(ex);
            Console.WriteLine("File not found.");
        }
        catch (Exception ex)
        {
            LogException(ex);
            Console.WriteLine("Something went wrong.");
        }
    }
    static void LogException(Exception ex)
    {
        File.AppendAllText("error.log",DateTime.Now + " | " + ex.GetType().Name + " | " +ex.Message + Environment.NewLine);
    }
}
*/
namespace BankingSystem{
class Program
{
    static void Main()
    {
        Program2.calculate();
    }
}
=======
﻿using System;
using System.Dynamic;
using System.IO;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
// class Program
// {
//     static void Main()
//     {
//         int a=10;
//         int b=0;
//         try
//         {
//             int result=a/b;
//         }catch(Exception ex)
//         {
//             Console.WriteLine("Error occured: "+ex.Message);
//         }
//     }
// }
/*
class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string Message) : base(Message){ }
}
class BankAccount
{
    public decimal Balance{get; private set;}=5000;
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be greater that zero");
        if(amount > Balance)
        throw new InsufficientBalanceException("Insufficient balance for withdrawal");
        Balance -= amount;
    }
}
class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter withdrawal amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            int serviceCharge = 100;
            //int divisionCheck = serviceCharge / int.Parse("0"); 

            string data = File.ReadAllText("error.log");

            BankAccount account = new BankAccount();
            account.Withdraw(amount);

            Console.WriteLine("Withdrawal successful.");

        }
        catch(FormatException ex)
        {
            LogException(ex);
            Console.WriteLine("Invalid input format.");
        }
        catch (DivideByZeroException ex)
        {
            LogException(ex);
            Console.WriteLine("Cannot divide by zero.");
        }
        catch (FileNotFoundException ex)
        {
            LogException(ex);
            Console.WriteLine("File not found.");
        }
        catch (Exception ex)
        {
            LogException(ex);
            Console.WriteLine("Something went wrong.");
        }
    }
    static void LogException(Exception ex)
    {
        File.AppendAllText("error.log",DateTime.Now + " | " + ex.GetType().Name + " | " +ex.Message + Environment.NewLine);
    }
}
*/

 class Program
{
    static void Main()
    {
        Program1.calculate();
        

    }
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
=======
﻿using System;
using System.Dynamic;
using System.IO;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
// class Program
// {
//     static void Main()
//     {
//         int a=10;
//         int b=0;
//         try
//         {
//             int result=a/b;
//         }catch(Exception ex)
//         {
//             Console.WriteLine("Error occured: "+ex.Message);
//         }
//     }
// }
/*
class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string Message) : base(Message){ }
}
class BankAccount
{
    public decimal Balance{get; private set;}=5000;
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be greater that zero");
        if(amount > Balance)
        throw new InsufficientBalanceException("Insufficient balance for withdrawal");
        Balance -= amount;
    }
}
class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter withdrawal amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            int serviceCharge = 100;
            //int divisionCheck = serviceCharge / int.Parse("0"); 

            string data = File.ReadAllText("error.log");

            BankAccount account = new BankAccount();
            account.Withdraw(amount);

            Console.WriteLine("Withdrawal successful.");

        }
        catch(FormatException ex)
        {
            LogException(ex);
            Console.WriteLine("Invalid input format.");
        }
        catch (DivideByZeroException ex)
        {
            LogException(ex);
            Console.WriteLine("Cannot divide by zero.");
        }
        catch (FileNotFoundException ex)
        {
            LogException(ex);
            Console.WriteLine("File not found.");
        }
        catch (Exception ex)
        {
            LogException(ex);
            Console.WriteLine("Something went wrong.");
        }
    }
    static void LogException(Exception ex)
    {
        File.AppendAllText("error.log",DateTime.Now + " | " + ex.GetType().Name + " | " +ex.Message + Environment.NewLine);
    }
}
*/

 class Program
{
    static void Main()
    {
        Program1.calculate();
        

    }
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
}