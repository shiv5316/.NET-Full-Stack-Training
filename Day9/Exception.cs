<<<<<<< HEAD
<<<<<<< HEAD
using System;
using System.IO;

class Program1
{
    public static void calculate()
    {
/*
####################################### EXCEPTION CODE ##############################################
        FileStream file = null;

        try
        {
            file = new FileStream("data.txt", FileMode.Open);

            // Perform file operation
            int data = file.ReadByte();
            Console.WriteLine("First byte read: " + data);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("File not found: " + ex.Message);
        }
        finally
        {
            if (file != null)
            {
                file.Close();
                Console.WriteLine("File stream closed in finally block.");
            }
        }
*/

/* ############# INNER EXCEPTION ###############################################################
        try
        {
            // Call service layer method
            DatabaseService();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Main Exception:");
            Console.WriteLine(ex.Message);

            if (ex.InnerException != null)
            {
                Console.WriteLine("\nInner Exception:");
                Console.WriteLine(ex.InnerException.Message);
            }
        }
    }

    static void DatabaseService()
    {
        try
        {
            // Simulating database failure
            throw new Exception("Connection failed");
        }
        catch (Exception ex)
        {
            // Wrapping low-level exception into higher-level exception
            throw new Exception("Database operation failed in Service Layer", ex);
        }

        
################################## NESTED TRY BLOCK #################################################
        try
{
    try
    {
        File.ReadAllText("transactions.txt");
    }
    catch (IOException ioEx)
    {
        throw new ApplicationException(
            "Unable to load transaction data",
            ioEx
        );
    }
}
catch (Exception ex)
{
    Console.WriteLine("Message: " + ex.Message);
    Console.WriteLine("Root Cause: " + ex.InnerException.Message);
}
*/
try
        {
            // Create account with initial balance
            BankAccount account = new BankAccount(5000);

            Console.Write("Enter withdrawal amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            account.Withdraw(amount);

            Console.WriteLine("Withdrawal successful.");
            Console.WriteLine("Remaining Balance: " + account.Balance);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Input Error: " + ex.Message);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine("Transaction Failed: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected Error: " + ex.Message);
        }
    }
}
public class BankAccount
{
    public decimal Balance { get; private set; }

    public BankAccount(decimal initialBalance)
    {
        if (initialBalance < 0)
            throw new ArgumentException("Initial balance cannot be negative", nameof(initialBalance));

        Balance = initialBalance;
    }

    public void Withdraw(decimal amount)
    {
        // Validate numeric range
        if (amount <= 0)
            throw new ArgumentException(
                "Withdrawal amount must be greater than zero",
                nameof(amount));

        // Enforce business rule
        if (amount > Balance)
            throw new InsufficientBalanceException(
                $"Cannot withdraw {amount:C}. Available balance: {Balance:C}");

        Balance -= amount;
    }
}
public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message)
        : base(message)
    {
    }
}

    

=======
using System;
using System.IO;

class Program1
{
    public static void calculate()
    {
/*
####################################### EXCEPTION CODE ##############################################
        FileStream file = null;

        try
        {
            file = new FileStream("data.txt", FileMode.Open);

            // Perform file operation
            int data = file.ReadByte();
            Console.WriteLine("First byte read: " + data);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("File not found: " + ex.Message);
        }
        finally
        {
            if (file != null)
            {
                file.Close();
                Console.WriteLine("File stream closed in finally block.");
            }
        }
*/

/* ############# INNER EXCEPTION ###############################################################
        try
        {
            // Call service layer method
            DatabaseService();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Main Exception:");
            Console.WriteLine(ex.Message);

            if (ex.InnerException != null)
            {
                Console.WriteLine("\nInner Exception:");
                Console.WriteLine(ex.InnerException.Message);
            }
        }
    }

    static void DatabaseService()
    {
        try
        {
            // Simulating database failure
            throw new Exception("Connection failed");
        }
        catch (Exception ex)
        {
            // Wrapping low-level exception into higher-level exception
            throw new Exception("Database operation failed in Service Layer", ex);
        }

        
################################## NESTED TRY BLOCK #################################################
        try
{
    try
    {
        File.ReadAllText("transactions.txt");
    }
    catch (IOException ioEx)
    {
        throw new ApplicationException(
            "Unable to load transaction data",
            ioEx
        );
    }
}
catch (Exception ex)
{
    Console.WriteLine("Message: " + ex.Message);
    Console.WriteLine("Root Cause: " + ex.InnerException.Message);
}
*/
try
        {
            // Create account with initial balance
            BankAccount account = new BankAccount(5000);

            Console.Write("Enter withdrawal amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            account.Withdraw(amount);

            Console.WriteLine("Withdrawal successful.");
            Console.WriteLine("Remaining Balance: " + account.Balance);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Input Error: " + ex.Message);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine("Transaction Failed: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected Error: " + ex.Message);
        }
    }
}
public class BankAccount
{
    public decimal Balance { get; private set; }

    public BankAccount(decimal initialBalance)
    {
        if (initialBalance < 0)
            throw new ArgumentException("Initial balance cannot be negative", nameof(initialBalance));

        Balance = initialBalance;
    }

    public void Withdraw(decimal amount)
    {
        // Validate numeric range
        if (amount <= 0)
            throw new ArgumentException(
                "Withdrawal amount must be greater than zero",
                nameof(amount));

        // Enforce business rule
        if (amount > Balance)
            throw new InsufficientBalanceException(
                $"Cannot withdraw {amount:C}. Available balance: {Balance:C}");

        Balance -= amount;
    }
}
public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message)
        : base(message)
    {
    }
}

    

>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
=======
using System;
using System.IO;

class Program1
{
    public static void calculate()
    {
/*
####################################### EXCEPTION CODE ##############################################
        FileStream file = null;

        try
        {
            file = new FileStream("data.txt", FileMode.Open);

            // Perform file operation
            int data = file.ReadByte();
            Console.WriteLine("First byte read: " + data);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("File not found: " + ex.Message);
        }
        finally
        {
            if (file != null)
            {
                file.Close();
                Console.WriteLine("File stream closed in finally block.");
            }
        }
*/

/* ############# INNER EXCEPTION ###############################################################
        try
        {
            // Call service layer method
            DatabaseService();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Main Exception:");
            Console.WriteLine(ex.Message);

            if (ex.InnerException != null)
            {
                Console.WriteLine("\nInner Exception:");
                Console.WriteLine(ex.InnerException.Message);
            }
        }
    }

    static void DatabaseService()
    {
        try
        {
            // Simulating database failure
            throw new Exception("Connection failed");
        }
        catch (Exception ex)
        {
            // Wrapping low-level exception into higher-level exception
            throw new Exception("Database operation failed in Service Layer", ex);
        }

        
################################## NESTED TRY BLOCK #################################################
        try
{
    try
    {
        File.ReadAllText("transactions.txt");
    }
    catch (IOException ioEx)
    {
        throw new ApplicationException(
            "Unable to load transaction data",
            ioEx
        );
    }
}
catch (Exception ex)
{
    Console.WriteLine("Message: " + ex.Message);
    Console.WriteLine("Root Cause: " + ex.InnerException.Message);
}
*/
try
        {
            // Create account with initial balance
            BankAccount account = new BankAccount(5000);

            Console.Write("Enter withdrawal amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            account.Withdraw(amount);

            Console.WriteLine("Withdrawal successful.");
            Console.WriteLine("Remaining Balance: " + account.Balance);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Input Error: " + ex.Message);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine("Transaction Failed: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected Error: " + ex.Message);
        }
    }
}
public class BankAccount
{
    public decimal Balance { get; private set; }

    public BankAccount(decimal initialBalance)
    {
        if (initialBalance < 0)
            throw new ArgumentException("Initial balance cannot be negative", nameof(initialBalance));

        Balance = initialBalance;
    }

    public void Withdraw(decimal amount)
    {
        // Validate numeric range
        if (amount <= 0)
            throw new ArgumentException(
                "Withdrawal amount must be greater than zero",
                nameof(amount));

        // Enforce business rule
        if (amount > Balance)
            throw new InsufficientBalanceException(
                $"Cannot withdraw {amount:C}. Available balance: {Balance:C}");

        Balance -= amount;
    }
}
public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message)
        : base(message)
    {
    }
}

    

>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
